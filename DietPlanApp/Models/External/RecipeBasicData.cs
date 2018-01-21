using Newtonsoft.Json;

namespace DietPlanApp.Models.External
{
    /// <summary>
    /// Data header of a single meal
    /// </summary>
    public class RecipeBasicData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
   
        public static RecipeBasicData FromJson(string json) => JsonConvert.DeserializeObject<RecipeBasicData>(json, Converter.Settings);
    }
}