using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Square_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SumOftheSquares = 0;
            double SquareoftheSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                SumOftheSquares += Math.Pow(i, 2);
            }

            for (int i = 1; i <= 100; i++)
            {
                SquareoftheSum += i;
            }
            SquareoftheSum = Math.Pow(SquareoftheSum, 2);
            Console.WriteLine(SquareoftheSum-SumOftheSquares);
            Console.ReadKey();
        }
    }
}
