using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShoppingWasm.Server.Services;
using BlazorShoppingWasm.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace BlazorShoppingWasm.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService articleService;
        private readonly ILogger<ArticleController> logger;

        public ArticleController(ILogger<ArticleController> logger, ArticleService articleService)
        {
            this.logger = logger;
            this.articleService = articleService;
        }

        [HttpGet("planning")]
        public async Task<List<PlanningSectionModel>> GetPlanning()
        {
            return await articleService.GetPlanningContent();
        }

        [HttpGet("shopping")]
        public async Task<List<ShoppingModel>> GetShopping()
        {
            return await articleService.GetShoppingContent();
        }

        [HttpPost("plan")]
        public async Task SetPlanning(PlanningModel planningModel)
        {
            await articleService.SetPlanning(planningModel);
        }

        [HttpPost("shop")]
        public async Task SetShoppingItem(ShoppingModel shoppingModel)
        {
            await articleService.ToggleShoppingItem(shoppingModel);
        }
    }
}