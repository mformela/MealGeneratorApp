using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.BusinessLogic
{
    public class BLBmi
    {
        public int CalculateBMI(int Weight, int Height)
        {
            var bmi = 1 * Weight / ((Height / 100) * (Height / 100));
            return bmi;
        }
    }
}