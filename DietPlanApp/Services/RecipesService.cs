using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace DietPlanApp.Services
{
    public class RecipesService
    {
        public class Recipes
        {
            public string IngredientsName { get; set; }
            public int Amount { get; set; }
        }


        static HttpClient client = new HttpClient();

        static void ShowRecipes (Recipes recipes)
        {

        }

       

        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://localhost:50679/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //GET
        static async Task<Recipes> GetRecipesAsync (string path)
        {
            Recipes recipes = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                recipes = await response.Content.ReadAsAsync<Recipes>();
            }
            return recipes;
        }

        //POST
        static async Task<Uri> CreateRecipesAsync(Recipes recipes)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/recipes", recipes);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        //PUT
        static async Task<Recipes> UpdateRecipesAsync(Recipes recipes)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/recipes/{recipes.IngredientsName}", recipes);
            response.EnsureSuccessStatusCode();

            recipes = await response.Content.ReadAsAsync<Recipes>();
            return recipes;

        }


        //static async Task<Recipes> DeleteRecipesAsync(string IngredientsName)
        //{
        //    HttpResponseMessage response = await client.DeleteAsync(
        //        $"api/recipes/{IngredientsName}");
        //    return response.StatusCode;
        //}
    }
}
