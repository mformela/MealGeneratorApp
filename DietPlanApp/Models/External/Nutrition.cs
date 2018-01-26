using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.Models.External
{
    public class Nutrition
    { 
            [JsonProperty("meals")]
            public Meal[] Meals { get; set; }

            [JsonProperty("nutrients")]
            public Nutrients Nutrients { get; set; }

            public static Nutrition FromJson(string json) => JsonConvert.DeserializeObject<Nutrition>(json, Converter.Settings);
    }

       

       
    }
   

   

