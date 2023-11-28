using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal kutya = new animal();
            animal medve = new animal();
            Console.WriteLine("Kutya");
            Console.WriteLine(kutya.hunger);
            Console.WriteLine(kutya.thirst);
            Console.WriteLine("Medve");
            Console.WriteLine(medve.hunger);
            Console.WriteLine(medve.thirst);

            sharpie kek = new sharpie();
            sharpie orange = new sharpie("orange", 3);
            kek.Use();
            Console.WriteLine(kek.inkAmount);
            Console.WriteLine(orange.inkAmount);
            Console.ReadKey();
        }
    }
}
