using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorShoppingWasm.Server.Data.Context;
using BlazorShoppingWasm.Server.Data.Mappers;
using BlazorShoppingWasm.Shared.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorShoppingWasm.Server.Services
{
    public class ArticleService
    {
        private readonly IDbContextFactory<ApplicationDbContext> dbFactory;

        public ArticleService(IDbContextFactory<ApplicationDbContext> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public async Task<List<PlanningSectionModel>> GetPlanningContent()
        {
            using (var context = dbFactory.CreateDbContext())
            {
                var sections = await context.Sections
                    .Include(s => s.Articles)
                    .ToListAsync();

                var activeShoppingItems = context.ShoppingItems
                                                .Where(s => s.PickTime == null)
                                                .ToList();

                return sections.Select(s => s.ToPlanningSection(activeShoppingItems))
                                .OrderBy(s => s.SectionOrder)
                                .ToList();
            }
        }

        public async Task SetPlanning(PlanningModel planningModel)
        {
            using (var context = dbFactory.CreateDbContext())
            {
                var shoppingItem = context.ShoppingItems.SingleOrDefault(a => a.ArticleId == planningModel.ArticleId);

                if (shoppingItem == null && planningModel.Quantity != 0)
                {
                    // Insert
                    shoppingItem = planningModel.ToShoppingItem();
                    context.Add(shoppingItem);
                    await context.SaveChangesAsync();
                    return;
                }

                if (shoppingItem != null)
                {
                    if (planningModel.Quantity != 0)
                    {
                        // Update
                        shoppingItem.Quantity = planningModel.Quantity;
                        shoppingItem.PickTime = null;
                    }
                    else
                    {
                        // Delete
                        context.Remove(shoppingItem);
                    }
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<List<ShoppingModel>> GetShoppingContent()
        {
            using (var context = dbFactory.CreateDbContext())
            {
                return await context.ShoppingItems
                    .Where(s => s.PickTime == null || s.PickTime.Value.Date == DateTime.Today)
                    .OrderBy(s => s.PickTime.HasValue).ThenBy(s => s.SectionOrder).ThenBy(s => s.ArticleOrder)
                    .Select(s => s.ToShoppingModel())
                    .ToListAsync();
            }
        }

        public async Task ToggleShoppingItem(ShoppingModel shoppingModel)
        {
            using (var context = dbFactory.CreateDbContext())
            {
                var shoppingItem = context.ShoppingItems.SingleOrDefault(s => s.Id == shoppingModel.Id);
                if (shoppingItem != null)
                {
                    shoppingItem.PickTime = shoppingModel.PickTime;
                    context.Update(shoppingItem);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}