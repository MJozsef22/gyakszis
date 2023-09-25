using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstrList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] haystack = { "this", "is", "what", "I'm", "searching", "in"};
            Console.WriteLine(FindIndex("not",haystack));

            Console.ReadKey(); 
        }

        private static int FindIndex(string v, string[] haystack)
        {
            int index = 0;
           foreach (var item in haystack) 
           { 
                if (item.Contains(v))
                {
                    return index;
                }
                index++;
           }
            return -1;
        }
    }
}
