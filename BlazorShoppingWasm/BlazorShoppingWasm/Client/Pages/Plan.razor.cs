using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShoppingWasm.Client.Services;
using BlazorShoppingWasm.Shared.Models;
using Microsoft.AspNetCore.Components;


namespace BlazorShoppingWasm.Client.Pages
{
    public partial class Plan
    {
        public IList<PlanningSectionModel> SectionModels = new List<PlanningSectionModel>();

        [Inject]
        public ArticleApi ArticleApi { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SectionModels = await ArticleApi.GetPlanningContent();
        }
    }
}