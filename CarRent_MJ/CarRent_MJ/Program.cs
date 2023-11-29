
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent_MJ
{
    internal class Program
    {
        static List<IO> data = new List<IO>();
        static void Main(string[] args)
        {
            foreach (var item in File.ReadAllLines("autok.txt"))
            {
                data.Add(new IO(item));
            }

            double sum = 0;

            foreach (var item in data)
            {
                sum += item.carDistance;
            }

            Console.WriteLine($"Avg distance: {sum / data.Count}");

            string answer = string.Empty;
            foreach (var item in data)
            {
                if (item.carName == "Skoda" && item.carType == "Superb")
                {
                    answer = "\nThe car exsist in the collection";
                    break;
                }
                else
                {
                    answer = "\nThe car doesnt exsist in the collection";
                }
            }

            Console.WriteLine(answer);

            int lowest = int.MaxValue;
            int highest = int.MinValue;

            foreach (var item in data)
            {
                if (lowest > item.carDistance)
                {
                    lowest = item.carDistance;
                }

                if (highest < item.carDistance)
                {
                    highest = item.carDistance;
                }

            }
            Console.WriteLine(lowest);
            foreach (var item in data)
            {
                if (item.carDistance == lowest || item.carDistance == highest)
                {
                    Console.WriteLine($"\nCar name:{item.carName}\nCar type:{item.carType}\n" +
                        $"Car distance: {item.carDistance}");
                }
            }



            Console.ReadKey();
        }
    }
}
