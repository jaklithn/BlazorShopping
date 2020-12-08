using System.Collections.Generic;


namespace BlazorShoppingServer.Models
{
    public class PlanningSectionModel
    {
        public string SectionName { get; set; }
        public int SectionOrder { get; set; }
        public List<PlanningModel> PlanningModels { get; set; } 
    }
}