using System;
using System.Collections.Generic;
using System.Linq;
using BlazorShoppingServer.Data;


namespace BlazorShoppingServer.Models.Mappers
{
    public static class PlanningMapper
    {
        public static PlanningSectionModel ToPlanningSection(this Section section, List<ShoppingItem> activeShoppingItems)
        {
            return new PlanningSectionModel
            {
                SectionName = section.Name,
                SectionOrder = section.Order,
                PlanningModels = section.Articles
                    .Select(a => a.ToPlanningModel(activeShoppingItems))
                    .OrderBy(a => a.ArticleOrder)
                    .ToList()
            };
        }

        private static PlanningModel ToPlanningModel(this Article article, List<ShoppingItem> activeShoppingItems)
        {
            return new PlanningModel
            {
                ArticleId = article.Id,
                ArticleName = article.Name,
                ArticleUnit = article.Unit,
                ArticleOrder = article.Order,

                SectionId = article.Section.Id,
                SectionName = article.Section.Name,
                SectionOrder = article.Section.Order,

                Quantity = activeShoppingItems.SingleOrDefault(s => s.ArticleId == article.Id)?.Quantity ?? 0
            };
        }

        public static ShoppingItem ToShoppingItem(this PlanningModel planningModel)
        {
            return new ShoppingItem
            {
                Id = Guid.NewGuid(),
                ArticleId = planningModel.ArticleId,
                ArticleName = planningModel.ArticleName,
                ArticleUnit = planningModel.ArticleUnit,
                ArticleOrder = planningModel.ArticleOrder,

                SectionId = planningModel.SectionId,
                SectionName = planningModel.SectionName,
                SectionOrder = planningModel.SectionOrder,

                Quantity = planningModel.Quantity
            };
        }
    }
}