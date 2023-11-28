using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elefant elefant = new Elefant("Dumbo", 2, gender.MALE);
            Console.WriteLine(elefant.getName());
            Console.WriteLine(elefant.getAge());
            Console.WriteLine(elefant.getGender());


            Console.ReadKey();
        }
    }
}
