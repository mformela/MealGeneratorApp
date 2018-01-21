using DietPlanApp.Models;
using DietPlanApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DietPlanApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var data = await GetMeals();

            var recipies = WeeklyRecipies.FromJson(data);

            var viewModel = new VMWeeklyRecipies() {
                WeeklyRecipies = recipies
            };

            return View("YourDietProfile", viewModel);
        }

        public async Task<string> GetMeals()
        {
            HttpClient client = new HttpClient();
            var basicUrl = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/mealplans/generate";

            // 'X-Mashape-Key: MZR5OHGXhbmshmITf5PCbdEeSl7zp1IaQnIjsnfF1x8yrAx9Ui'

            var builder = new UriBuilder(basicUrl);
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["diet"] = "vegetarian";
            query["targetCalories"] = "2000";
            query["timeFrame"] = "week";
            builder.Query = query.ToString();
            string url = builder.ToString();

            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.DefaultRequestHeaders.Add("X-Mashape-Key", "MZR5OHGXhbmshmITf5PCbdEeSl7zp1IaQnIjsnfF1x8yrAx9Ui");
                return await httpClient.GetStringAsync(url);
                //return JsonConvert.DeserializeObject<List<Car>>(
                //    await httpClient.GetStringAsync(uri)
                //);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddInfo()
        {
            ViewBag.Message = "additional information";

            return View();
        }

        public ActionResult Allergens()
        {
            ViewBag.Message = "info about the allergens.";

            return View();
        }

        public ActionResult PhysicalActivity()
        {
            ViewBag.Message = "excercises.";

            return View();
        }

        public ActionResult Diets()
        {
            ViewBag.Message = "Different kind of diets";

            return View();
        }

       
    }
}