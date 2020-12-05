using System;


namespace BlazorShopping.Models
{
    public class ShoppingModel
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleUnit { get; set; }
        public int ArticleOrder { get; set; }

        public float Quantity { get; set; }
        public DateTime? PickTime { get; set; }

        public bool IsSelected
        {
            get => PickTime.HasValue;
            set => PickTime = value ? DateTime.Now : (DateTime?)null;
        }

    }
}