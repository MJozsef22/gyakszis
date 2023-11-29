using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2_MJ
{
    internal class CarSell : CarRenter
    {
        
        public CarSell(List<Car> cars) : base(cars)
        {
        }

        public void sell(string plateNumber)
        {
            foreach (Car car in cars)
            {
                if (car.plateNumber.Contains(plateNumber))
                {
                    cars.Remove(car);
                    Console.WriteLine("\"You sold the car.");
                    
                }
            }
        }
    }
}
