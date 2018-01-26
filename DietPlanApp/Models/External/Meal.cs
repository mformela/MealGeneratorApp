using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.Models.External
{
    public class Meal
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
}