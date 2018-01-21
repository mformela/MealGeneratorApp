using DietPlanApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DietPlanApp.Data_Access_Layer
{
    public class UserProfileContext : DbContext
    {
        public UserProfileContext() : base("connectionString")
        {
        }
        public DbSet<UserProfileModels> UserProfileModels { get; set; }
    
    }
}