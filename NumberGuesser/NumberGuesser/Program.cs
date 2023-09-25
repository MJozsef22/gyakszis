using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I gonna guees ur number!");
            int lives = 5;
            Console.WriteLine("Give me the min and max value:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string str = string.Empty;
            try
            {
                do
                {
                    int guess = (a + b) / 2;
                    Console.WriteLine($"Is your number {guess}? (yes/no)");
                    str = Console.ReadLine().ToLower();

                    if (str == "yes")
                    {
                        Console.WriteLine("I guessed your number!");
                        break;
                    }
                    else if (str == "no")
                    {
                        Console.WriteLine("Is it higher or lower than my guess? (higher/lower)");
                        string highLow = Console.ReadLine().ToLower();

                        if (highLow == "higher")
                        {
                            a = guess + 1;
                            lives--;
                            Console.WriteLine($"{lives} try left.");
                        }
                        else if (highLow == "lower")
                        {
                            b = guess - 1;
                            lives--;
                            Console.WriteLine($"{lives} try left.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter 'higher' or 'lower'.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                    }
                }
                while (str != "yes" && lives > 0);

                Console.WriteLine("Thanks for playing!");
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
            }
            
           

            Console.ReadKey();
        }
    }
}
