using System;
using BlazorShoppingWasm.Server.Data.Context;


namespace BlazorShoppingWasm.Server.Data
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