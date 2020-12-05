using System;
using BlazorShopping.Data.Context;


namespace BlazorShopping.Data
{
    public class Article : DbEntity
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Order { get; set; }
		
        public Guid SectionId { get; set; }
        public Section Section { get; set; }
    }
}