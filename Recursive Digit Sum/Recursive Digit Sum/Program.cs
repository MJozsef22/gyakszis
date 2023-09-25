using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Digit_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = "148";
            int k = n.ToString().Length;

            Console.WriteLine(superDigit(n,k));
            Console.ReadKey();
        }


        public static int superDigit(string n,int k) 
        {
            if (n.Length == 1)//stop elem
            {
                return int.Parse(n);
            }

            
            double initialSum = 0;
            foreach (char digit in n)
            {
                initialSum += (digit - '0'); //char convertálás int("tipussá") hogy összetudjunk adni
            }
            initialSum *= k;

            
            return superDigit(initialSum.ToString(), 1);//rekurzív számolás
        }
    }
}
