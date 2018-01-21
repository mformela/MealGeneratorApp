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
using DietPlanApp.Models.External;
using Microsoft.AspNet.Identity;

namespace DietPlanApp.Controllers
{
    public class HomeController : Controller
    {
        private const string ApiKeyLabel = "X-Mashape-Key";
        private const string ApiKey = "MZR5OHGXhbmshmITf5PCbdEeSl7zp1IaQnIjsnfF1x8yrAx9Ui";

        public ActionResult Index()
        {

            var userId = User.Identity.GetUserId();

            var db = new ApplicationDbContext();

            var profile = db.UserProfiles.SingleOrDefault(up => up.UserId == userId);

            if (profile == null)
            {
                // we did not found profile, redirect to details
                return RedirectToAction("FillOut", "Profile");
            }

            return View();
        }

        public async Task<ActionResult> YourDietProfile()
        {
            var data = await GetMeals();

            var recipies = WeeklyRecipies.FromJson(data);

            var viewModel = new VMWeeklyRecipies() {
                WeeklyRecipies = recipies
            };

            return View(viewModel);
        }

        public async Task<string> GetMeals()
        {
            const string basicUrl = "https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/mealplans/generate";

            var builder = new UriBuilder(basicUrl)
            {
                Port = -1,
            };
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["diet"] = "vegetarian";
            query["targetCalories"] = "2000";
            query["timeFrame"] = "week";

            builder.Query = query.ToString();
            var url = builder.ToString();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add(ApiKeyLabel, ApiKey);
                return await httpClient.GetStringAsync(url);
            }
        }

        public async Task<ActionResult> MealDetails(long id)
        {
            var mealDetailsData = await GetMealsDetails(id);

            var mealDetails = Models.External.MealDetails.FromJson(mealDetailsData);

            return View(mealDetails);
        }

        public async Task<string> GetMealsDetails(long id)
        {
            var basicUrl = $"https://spoonacular-recipe-food-nutrition-v1.p.mashape.com/recipes/{id}/information";

            var builder = new UriBuilder(basicUrl) {Port = -1};
            var url = builder.ToString();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add(ApiKeyLabel, ApiKey);
                return await httpClient.GetStringAsync(url);
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