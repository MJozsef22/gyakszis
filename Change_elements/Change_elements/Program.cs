using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = new string[] { "third", "first", "second" };
            //Linq

            Console.WriteLine(string.Join(", ", str.OrderBy(s => s)));

            //by Index
            (str[0], str[1]) = (str[1], str[0]);
            (str[1], str[2]) = (str[2], str[1]);


            Console.WriteLine(string.Join(", ", str));
            Console.ReadKey();
        }
    }
}
