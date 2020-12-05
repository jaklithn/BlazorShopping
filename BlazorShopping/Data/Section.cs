using System.Collections.Generic;
using BlazorShopping.Data.Context;


namespace BlazorShopping.Data
{
    public class Section : DbEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }

        public List<Article> Articles { get; set; }
    }
}