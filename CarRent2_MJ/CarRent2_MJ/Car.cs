using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2_MJ
{
    public class Car
    {
        public string type;
        public string color;
        public string plateNumber;
        public double rentPerDayPrice;
        public double fuelConsuptionPerDay;
        public double currentFuel = 100.0;
        public bool rentAvailable = true;

        public Car(string color, string plateNumber)
        {
            type = GetType().Name;
            this.color = color;
            this.plateNumber = plateNumber;
        }

        public void properties()
        {
            Console.WriteLine($"A {color} colored" +
                $" {type} car with {currentFuel} fuel.\n" +
                $"It'S daily consuption is {fuelConsuptionPerDay} and it's licence number is: {plateNumber}");
            if (rentAvailable) { Console.WriteLine("This car is available"); }
            else { Console.WriteLine("This car is not available"); }
        }

        public void refil_recharge(Car car)
        {
            Console.WriteLine("Refilling the car..");
        }

    }
}
