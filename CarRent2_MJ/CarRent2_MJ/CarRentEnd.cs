using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2_MJ
{
    internal class CarRentEnd : CarRenter
    {
        public CarRentEnd(List<Car> cars) : base(cars)
        {
            foreach (var car in cars)
            {
                if (!car.rentAvailable)
                {
                    car.rentAvailable = true;
                }
            }
        }

        public void infos()
        {
            foreach (var car in cars)
            {
                car.properties();
            }
        }

    }
}
