using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.Models
{
    public class Nutrition
    { 
            [JsonProperty("meals")]
            public Meal[] Meals { get; set; }

            [JsonProperty("nutrients")]
            public Nutrients Nutrients { get; set; }
        }

        public partial class Meal
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("readyInMinutes")]
            public long ReadyInMinutes { get; set; }

            [JsonProperty("image")]
            public string Image { get; set; }

            [JsonProperty("imageUrls")]
            public string[] ImageUrls { get; set; }
        }

        public partial class Nutrients
        {
            [JsonProperty("calories")]
            public long Calories { get; set; }

            [JsonProperty("protein")]
            public double Protein { get; set; }

            [JsonProperty("fat")]
            public double Fat { get; set; }

            [JsonProperty("carbohydrates")]
            public double Carbohydrates { get; set; }
        }
    }
    public partial class Nutrition
    {
        public static Nutrition FromJson(string json) => JsonConvert.DeserializeObject<Nutrition>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Nutrition self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }

