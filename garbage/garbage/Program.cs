using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(below1000());
            Console.WriteLine(sunOFevens());
            Console.WriteLine(Palindrome());
            Console.WriteLine(Powerful_Digit_Counts());
            Console.ReadKey();
        }

        #region Find the sum of all the multiples of 3 or  5 below 1000
        static int below1000()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        #endregion

        #region fibonacci even
        static int sunOFevens()
        {
            int limit = 4000000;
            int sum = 0;
            int a = 1;
            int b = 2;

            while (a <= limit)
            {
                if (a % 2 == 0)
                {
                    sum += a;
                }

                int temp = a;
                a = b;
                b = temp + b;
            }
            return sum;
        }
        #endregion

        #region Largest Palindrome Product
        static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();
            int length = numberStr.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (numberStr[i] != numberStr[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static int Palindrome()
        {
            int largestPalindrome = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    if (IsPalindrome(product) && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }
            return largestPalindrome;

        }
        #endregion

        #region 63
        static int Powerful_Digit_Counts()
        {
            int count = 0;

            for (int baseNum = 1; baseNum < 10; baseNum++)
            {
                for (int exponent = 1; ; exponent++)
                {
                    double result = Math.Pow(baseNum, exponent);
                    int resultDigits = (int)Math.Log10(result) + 1;

                    if (resultDigits == exponent)
                    {
                        count++;
                    }
                    else if (resultDigits < exponent)
                    {
                        break;
                    }
                }
            }
                return count;
        }
        #endregion
    }
}
