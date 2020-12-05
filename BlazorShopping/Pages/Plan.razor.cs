using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShopping.Models;


namespace BlazorShopping.Pages
{
    public partial class Plan
    {
        private IList<PlanningSectionModel> sectionModels = new List<PlanningSectionModel>();

        protected override async Task OnInitializedAsync()
        {
            sectionModels = await ArticleService.GetPlanningContent();
            await base.OnInitializedAsync();
        }
    }
}