using System.Collections.Generic;
using Newtonsoft.Json;

namespace DietPlanApp.Models.External
{
    public class ExtendedIngredient
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("aisle")]
        public string Aisle { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("unitShort")]
        public string UnitShort { get; set; }

        [JsonProperty("unitLong")]
        public string UnitLong { get; set; }

        [JsonProperty("originalString")]
        public string OriginalString { get; set; }

        [JsonProperty("metaInformation")]
        public List<string> MetaInformation { get; set; }
    }
}