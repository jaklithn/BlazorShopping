using BlazorShoppingWasm.Shared.Models;


namespace BlazorShoppingWasm.Server.Data.Mappers
{
    public static class ShoppingMapper
    {
        public static ShoppingModel ToShoppingModel(this ShoppingItem shoppingItem)
        {
            return new ShoppingModel
            {
                Id = shoppingItem.Id,
                ArticleId = shoppingItem.ArticleId,
                ArticleName = shoppingItem.ArticleName,
                ArticleUnit = shoppingItem.ArticleUnit,
                ArticleOrder = shoppingItem.ArticleOrder,

                Quantity = shoppingItem.Quantity,
                PickTime = shoppingItem.PickTime
            };
        }
    }
}