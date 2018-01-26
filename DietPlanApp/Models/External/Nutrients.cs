using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.Models.External
{
    public class Nutrients
    {
            [JsonProperty("calories")]
            public long Calories { get; set; }

            [JsonProperty("protein")]
            public double Protein { get; set; }

            [JsonProperty("fat")]
            public double Fat { get; set; }

            [JsonProperty("carbohydrates")]
            public double Carbohydrates { get; set; }

        public static Nutrients FromJson(string json) => JsonConvert.DeserializeObject<Nutrients>(json, Converter.Settings);
    }
}