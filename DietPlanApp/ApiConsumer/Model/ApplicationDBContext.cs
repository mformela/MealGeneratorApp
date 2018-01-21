using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DietPlanApp.ApiConsumer.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(): base ("DefaultConnection")
        {

        }

        public DbSet<Performance> Performances { get; set; }
        
    }
}