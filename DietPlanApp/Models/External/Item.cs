using Newtonsoft.Json;

namespace DietPlanApp.Models.External
{
    /// <summary>
    /// An instance of a single meal metadata
    /// </summary>
    public class Item
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

        public RecipeBasicData RecipeBasicData =>  RecipeBasicData.FromJson(Value);

       
    }
}