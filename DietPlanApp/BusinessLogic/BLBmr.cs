using DietPlanApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.BusinessLogic
{
    public class BLBmr
    {
        public double CalculateBMR(int Weight, int Height, int Age)
        {
            var i = Gender.Man;
            if (i == Gender.Man)
            {
                double bmr = (10 * Convert.ToDouble(Weight)) + (6.25 * Convert.ToDouble(Height)) - (5 * Convert.ToDouble(Age)) + 5;
                return bmr;
            }
            else
            {
                double bmr = (10 * Weight) + (6.25 * Height) - (5 * Age) - 161;
                return bmr;
            }
        }
    }
}
