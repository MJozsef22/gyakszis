using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_prime_factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LPF(600851475143,2));
            Console.ReadKey();
        }

        static long LPF(long numb, long oszto)
        {
            if (numb <= 1)
            { return oszto-1; }
            if (numb % oszto == 0)
            {
                while (numb % oszto == 0) 
                { numb /= oszto; }
            }
            return LPF(numb, oszto + 1);
        }
    }
}
