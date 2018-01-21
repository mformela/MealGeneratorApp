using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace DietPlanApp.Models.External
{

    /// <summary>
    /// Table of reciepies for a week
    /// </summary>
    public class WeeklyRecipies 
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    
        public static WeeklyRecipies FromJson(string json) => JsonConvert.DeserializeObject<WeeklyRecipies>(json, Converter.Settings);
    }
}