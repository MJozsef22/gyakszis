using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a minimum és maximum értéket:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int generatedNumber = rnd.Next(a, b + 1);
            int lives = 5;
            string str = string.Empty;
            Console.WriteLine($"\n   Gondoltam egy számra {a}-{b} között.Találd ki!");

            try
            {

                do
                {
                    Console.Write("\n   Tipelj!:");
                    int guessedNumber = Convert.ToInt32(Console.ReadLine());
                    str = "";
                    Console.WriteLine(str);
                    if (generatedNumber == guessedNumber)
                    {
                        Console.WriteLine("\n   Gratulálok!");
                        break;
                    }
                    else
                    {
                        lives--;

                        Console.WriteLine(str = generatedNumber > guessedNumber ?
                            "   A szám ennél nagyobb.  " + lives + " életed maradt." : "  A szám ennél kisebb.  " + lives + " életed maradt.");
                    }

                }
                while (lives > 0);
            }
            catch (Exception)
            {
                Console.WriteLine("\n   Hiba történt!");
            }

            Console.ReadKey();
        }

    }
}
