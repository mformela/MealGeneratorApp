using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DietPlanApp.Models;
using Microsoft.AspNet.Identity;

namespace DietPlanApp.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            // TODO: Create a view displaying profile

            var userId = User.Identity.GetUserId();
            var db = new ApplicationDbContext();
            var profile = db.UserProfiles.SingleOrDefault(up => up.UserId == userId);

            if (profile == null) return RedirectToAction("FillOut");

            return View(profile);
        }

        public ActionResult FillOut()
        {
            // TODO: Display form to fill out
            return View();
        }

        [HttpPost]
        public ActionResult FillOut(string name, string surname, Gender gender, int age, int weight, int height)
        {
            try
            {
                var userId = User.Identity.GetUserId();

                var db = new ApplicationDbContext();
                var user = db.Users.SingleOrDefault(u => u.Id == userId);
                // if the logged in user does not exist, something is seriously wrong here
                if (user == null) return new HttpStatusCodeResult(HttpStatusCode.InternalServerError); ;


                var profile = new UserProfile()
                {
                    UserId = userId,
                    MailAddress = user.Email,
                    Name = name,
                    Surname = surname,
                    Gender = Gender.Man,
                    Age = age,
                    Weight = weight,
                    Height = height,
                    // placeholder
                    PhysicalActivity = PhysicalActivityType.Medium
                };

                db.UserProfiles.Add(profile);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
            
        }
    }
}