using DietPlanApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.ViewModels
{
    public class VMWeeklyRecipies
    {
        public WeeklyRecipies WeeklyRecipies { get; set; }
        public Nutrition Nutrition { get; set; }
        public RecipeBasicData RecipeBasicData { get; set;}
    }

}
