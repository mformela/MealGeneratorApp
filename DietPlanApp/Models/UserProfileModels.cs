using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.Models
{
    public class UserProfileModels
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MailAdress { get; set; }
        public string Password { get; set; }
        public string VeryfiyPassword { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int PhysicalActivity { get; set; }
    }
}