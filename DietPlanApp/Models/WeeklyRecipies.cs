using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace DietPlanApp.Models
{

    public partial class WeeklyRecipies 
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("mealPlanId")]
        public long MealPlanId { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        public RecipeBasicData RecipeBasicData
        {
            get
            {
                return RecipeBasicData.FromJson(this.Value);
            }
        }
    }

    public partial class WeeklyRecipies
    {
        public static WeeklyRecipies FromJson(string json) => JsonConvert.DeserializeObject<WeeklyRecipies>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this WeeklyRecipies self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }

    public partial class RecipeBasicData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public partial class RecipeBasicData
    {
        public static RecipeBasicData FromJson(string json) => JsonConvert.DeserializeObject<RecipeBasicData>(json, Converter.Settings);
    }
}