using System.Collections.Generic;
using Newtonsoft.Json;

namespace DietPlanApp.Models.External
{
    /// <summary>
    /// Details of a single meal recipe
    /// </summary>
    public partial class MealDetails
    {
        [JsonProperty("vegetarian")]
        public bool Vegetarian { get; set; }

        [JsonProperty("vegan")]
        public bool Vegan { get; set; }

        [JsonProperty("glutenFree")]
        public bool GlutenFree { get; set; }

        [JsonProperty("dairyFree")]
        public bool DairyFree { get; set; }

        [JsonProperty("veryHealthy")]
        public bool VeryHealthy { get; set; }

        [JsonProperty("cheap")]
        public bool Cheap { get; set; }

        [JsonProperty("veryPopular")]
        public bool VeryPopular { get; set; }

        [JsonProperty("sustainable")]
        public bool Sustainable { get; set; }

        [JsonProperty("weightWatcherSmartPoints")]
        public long WeightWatcherSmartPoints { get; set; }

        [JsonProperty("gaps")]
        public string Gaps { get; set; }

        [JsonProperty("lowFodmap")]
        public bool LowFodmap { get; set; }

        [JsonProperty("ketogenic")]
        public bool Ketogenic { get; set; }

        [JsonProperty("whole30")]
        public bool Whole30 { get; set; }

        [JsonProperty("servings")]
        public long Servings { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }

        [JsonProperty("spoonacularSourceUrl")]
        public string SpoonacularSourceUrl { get; set; }

        [JsonProperty("aggregateLikes")]
        public long AggregateLikes { get; set; }

        [JsonProperty("creditText")]
        public string CreditText { get; set; }

        [JsonProperty("sourceName")]
        public string SourceName { get; set; }

        [JsonProperty("extendedIngredients")]
        public List<ExtendedIngredient> ExtendedIngredients { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("readyInMinutes")]
        public long ReadyInMinutes { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        public static MealDetails FromJson(string json) => JsonConvert.DeserializeObject<MealDetails>(json, Converter.Settings);
    }
}