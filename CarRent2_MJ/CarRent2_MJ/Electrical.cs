using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2_MJ
{
    internal class Electrical : Car
    {
        public Electrical(string color, string plateNumber) : base(color, plateNumber)
        {
            fuelConsuptionPerDay = 3.4;
            rentPerDayPrice = 16.59;
        }
    }
}
