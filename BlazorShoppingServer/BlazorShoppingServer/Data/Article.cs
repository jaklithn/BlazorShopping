using System;
using BlazorShoppingServer.Data.Context;


namespace BlazorShoppingServer.Data
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