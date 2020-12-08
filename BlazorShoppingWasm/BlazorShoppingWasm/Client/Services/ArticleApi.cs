using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorShoppingWasm.Shared.Models;


namespace BlazorShoppingWasm.Client.Services
{
    public class ArticleApi
    {
        private readonly HttpClient http;

        public ArticleApi(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<PlanningSectionModel>> GetPlanningContent()
        {
           return await http.GetFromJsonAsync<List<PlanningSectionModel>>("Article/Planning");
        }

        public async Task<List<ShoppingModel>> GetShoppingContent()
        {
            return await http.GetFromJsonAsync<List<ShoppingModel>>("Article/Shopping");
        }

        public async Task SetPlanning(PlanningModel planningModel)
        {
            await http.PostAsJsonAsync("Article/Plan", planningModel);
        }

        public async Task ToggleShopping(ShoppingModel shoppingModel)
        {
            await http.PostAsJsonAsync("Article/Shop", shoppingModel);
        }
    }
}