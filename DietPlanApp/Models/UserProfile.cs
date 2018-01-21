using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DietPlanApp.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MailAddress { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public PhysicalActivityType PhysicalActivity { get; set; }
    }

    public enum PhysicalActivityType
    {
        Sitting,
        Low,
        Medium,
        High
    }
}