using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revese_order
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] temp = File.ReadAllLines("reversed-order.txt");

            for (int i = temp.Length - 1; i > 0; i--)
            {
                Console.WriteLine(temp[i]);
            }

            Console.ReadKey();

        }
    }
}
