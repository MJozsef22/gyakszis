using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 153;
            Console.WriteLine(isArmstrongNumber(a));

            Console.ReadKey();
        }

        static bool isArmstrongNumber(int num)
        {

            int temp = num;
            int i = 0;
            int digits = 0;
            int[] digitArray = new int[10];
            
            double result = 0;
            while (temp > 0)
            {
                digitArray[i++] = temp % 10;
                temp = temp / 10;
                digits++;
            }

            for (i = 0; i < digits; i++)
            {
                result += Math.Pow(digitArray[i], digits);
            }

            if (num == result)
            { return true; }

            return false;
        }
    }
}
