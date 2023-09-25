using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallest_multiply
{
    internal class Program
    {
        static long GCD(long a, long b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        static long LCM(long a, long b)
        {
            return (a * b) / GCD(a, b);
        }

        static long FindSmallestMultiple(int n, int current)
        {
            if (current == n)
                return current;

            return LCM(current, FindSmallestMultiple(n, current + 1));
        }

        static void Main()
        {
            int n = 20;
            long smallestMultiple = FindSmallestMultiple(n, 1);

            Console.WriteLine("Smallest positive number evenly divisible by numbers 1 to 20 is: " + smallestMultiple);

            Console.ReadKey();
        }
    }
}
