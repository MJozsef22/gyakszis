using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2_MJ
{
    internal class CarRenting : CarRenter
    {
        public int rentForDay;
        public CarRenting(List<Car> cars) : base(cars)
        {
        }

        public void renting()
        {

            foreach (var car in cars)
            {
                if (!car.rentAvailable) { Console.WriteLine("The car is currently booked by someone."); }
                else if (car.rentAvailable)
                {
                    if (car.currentFuel < 15)
                    {
                        Console.WriteLine("You need to refil the car");
                        car.refil_recharge(car);
                    }
                    else
                    {
                        Console.WriteLine($"You can rent the car.\n" +
                            $"The price for 1 day is: ${car.rentPerDayPrice}/day>" +
                            $"Renting the car for {rentForDay} days is: ${car.rentPerDayPrice * rentForDay}");
                        car.currentFuel -= car.fuelConsuptionPerDay * rentForDay;
                        car.rentAvailable = false;
                    }
                }

            }
        }

    }
}
