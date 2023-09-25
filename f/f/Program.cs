using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine(RFactorial(100));

            Console.ReadKey();
        }

        public static BigInteger RFactorial(int number)
        {

            if (number == 0)

            {

                return 1;

            }

            return number * RFactorial(number - 1);
        }

       
    }
}
