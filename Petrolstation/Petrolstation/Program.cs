using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrolstation
{
    class Car
    {
        public int gasAmount = 0;
        public const int capacity = 100;


        public bool isEmpty()
        { return gasAmount > 0 ? false : true; }

        public void carGoVroom()
        {

            if (isEmpty())
            {
                Console.WriteLine("No gas :(");
                return;
            }
            Console.WriteLine("Im so speeeeed!");
            gasAmount -= 10;
        }
    }

    class Station
    {
        public int gasAmount = 1000;

        public void refill(Car car)
        {
            gasAmount -= 100 - car.gasAmount;
            car.gasAmount += 100 - car.gasAmount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Station shell = new Station();
            Car mazda = new Car();
            mazda.carGoVroom();
            mazda.isEmpty();
            shell.refill(mazda);
            mazda.isEmpty();
            Console.WriteLine(mazda.gasAmount);
            Console.WriteLine(shell.gasAmount);
            mazda.carGoVroom();
            mazda.carGoVroom();
            mazda.carGoVroom();
            mazda.carGoVroom();
            mazda.carGoVroom();
            mazda.carGoVroom();

            Console.WriteLine(mazda.gasAmount);
            shell.refill(mazda);
            Console.WriteLine(shell.gasAmount);


            Console.ReadKey();
        }
    }

}

