using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2_MJ
{
    internal class CarBuy : CarRenter
    {
        public Car car;

        public CarBuy(List<Car> cars) : base(cars)
        {

        }

        public void buy(Car car)
        {
            cars.Add(car);
            Console.WriteLine("Congratulations on your new purchase!");
        }
    }
}
