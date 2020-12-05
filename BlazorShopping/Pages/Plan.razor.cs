using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShopping.Models;
using BlazorShopping.Services;
using Microsoft.AspNetCore.Components;


namespace BlazorShopping.Pages
{
    public partial class Plan
    {
        [Inject] 
        public ArticleService ArticleService { get; set; }

        private IList<PlanningSectionModel> sectionModels = new List<PlanningSectionModel>();

        protected override async Task OnInitializedAsync()
        {
            sectionModels = await ArticleService.GetPlanningContent();
            await base.OnInitializedAsync();
        }
    }
}