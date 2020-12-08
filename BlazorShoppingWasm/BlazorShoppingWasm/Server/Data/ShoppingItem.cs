using System;
using BlazorShoppingWasm.Server.Data.Context;


namespace BlazorShoppingWasm.Server.Data
{
    public class ShoppingItem : DbEntity
    {
        public Guid ArticleId { get; set; }
		public string ArticleName { get; set; }
        public string ArticleUnit { get; set; }
        public int ArticleOrder { get; set; }

        public Guid SectionId { get; set; }
        public string SectionName { get; set; }
        public int SectionOrder { get; set; }
		
        public float Quantity { get; set; }

        public DateTime? PickTime { get; set; }
    }
}