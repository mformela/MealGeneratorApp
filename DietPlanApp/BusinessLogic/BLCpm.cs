using DietPlanApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.BusinessLogic
{
    public class BLCpm
    {
        public double CalculatePartCPM(int Weight, int Height, int Age)
        {
            var i = Gender.Man;
            if (i == Gender.Man)
            {
                var cpm = 66.47 + (13.75 * Convert.ToDouble(Weight)) + (5.00 * Convert.ToDouble(Height)) - (6.75 * Convert.ToDouble(Age));
                return cpm;
            }
            else
            {
                var cpm = 665.09 + (9.56 * Convert.ToDouble(Weight)) + (1.85 * Convert.ToDouble(Height)) - (4.67 * Convert.ToDouble(Age));
                return cpm;
            }
        }
    }
}

        //public double CalculateCPM(PhysicalActivityType physicalAcivity)
        //{
        //    switch(physicalAcivity)
        //    {
        //        case 1:
        //        var cpm_total = cpm * 1.2;
        //        return cpm_total;
        //            break;

        //        case 2:
            
        //    if (PhysicalActivity == 2)
        //    {
        //        var cpm_total = cpm * 1.4;
        //        return cpm_total;

        //    }
        //    if (PhysicalActivity == 3)
        //    {
        //        var cpm_total = cpm * 1.6;
        //        return cpm_total;

        //    }
        //    if (PhysicalActivity == 4)
        //    {
        //        var cpm_total = cpm * 1.75;
        //        return cpm_total;

        //    }
        //    if (PhysicalActivity == 5)
        //    {
        //        var cpm_total = cpm * 2;
        //        return cpm_total;
        //        d
        //    }
        //    if (PhysicalActivity == 6)
        //    {
        //        var cpm_total = cpm * 2.2;
        //        return cpm_total;

        //    }
        //}
    //}


           