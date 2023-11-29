using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2_MJ
{
    internal class Diesel : Car
    {
        public Diesel(string color, string plateNumber) : base(color, plateNumber)
        {
            fuelConsuptionPerDay = 5.5;
            rentPerDayPrice = 12.59;
        }
    }
}
