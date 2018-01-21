using Newtonsoft.Json;

namespace DietPlanApp.Models.External
{
    public static class Serialize
    {
        public static string ToJson(this WeeklyRecipies self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}