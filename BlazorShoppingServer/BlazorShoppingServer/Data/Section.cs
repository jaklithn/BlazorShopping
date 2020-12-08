using System.Collections.Generic;
using BlazorShoppingServer.Data.Context;


namespace BlazorShoppingServer.Data
{
    public class Section : DbEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }

        public List<Article> Articles { get; set; }
    }
}