using System.Collections.Generic;
using BlazorShoppingWasm.Server.Data.Context;


namespace BlazorShoppingWasm.Server.Data
{
    public class Section : DbEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }

        public List<Article> Articles { get; set; }
    }
}