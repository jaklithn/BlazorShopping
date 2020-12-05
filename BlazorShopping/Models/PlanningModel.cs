using System;


namespace BlazorShopping.Models
{
    public class PlanningModel
    {
        public Guid ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleUnit { get; set; }
        public int ArticleOrder { get; set; }

        public Guid SectionId { get; set; }
        public string SectionName { get; set; }
        public int SectionOrder { get; set; }

        public float Quantity { get; set; }
    }
}