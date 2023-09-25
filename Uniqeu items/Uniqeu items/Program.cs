using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniqeu_items
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ",FindUniuqeItems(new[] { 1, 11, 34, 11, 52, 61, 1 })));

            Console.ReadKey();
        }

        public static int[] FindUniuqeItems(int[] givenArray)
        {
            
            HashSet<int> haset = new HashSet<int>(givenArray);
            return haset.ToArray() ;
        }
    }
}
