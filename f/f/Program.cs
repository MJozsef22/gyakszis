using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(120));
            Console.ReadKey();
        }

        public static double Factorial(int num)
        {
            
            if (num == 0)
            {

                return 1;
            }
            else if (num == 1)
            { return num ; }

            return num * Factorial(num-1);
        }
    }
}
