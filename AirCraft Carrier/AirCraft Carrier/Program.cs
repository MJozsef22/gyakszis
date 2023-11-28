using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft_Carrier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrier carrier1 = new Carrier(5000, 150);

            F16 af16 = new F16();
            F16 bf16 = new F16();
            F16 cf16 = new F16();

            F35 af35 = new F35();
            F35 bf35 = new F35();
            F35 cf35 = new F35();


            carrier1.add(af16);
            carrier1.add(bf16);
            carrier1.add(cf16);
            carrier1.add(cf35);
            carrier1.add(af35);
            carrier1.add(bf35);

            Console.WriteLine(carrier1.getStatus());

            Console.ReadKey();
        }
    }
}
