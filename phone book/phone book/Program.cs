using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_book
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dic = new Dictionary<string, string>();

            dic.Add("William A. Lathan", "405-709-1865");
            dic.Add("John K. Miller", "402-247-8568");
            dic.Add("Hortensia E. Foster", "606-481-6467");
            dic.Add("Amanda D. Newland", "319-243-5613");
            dic.Add("Boroke P. Askew", "307-687-2982");

            foreach (var item in dic)
            {
                if (item.Key == "John K. Miller")
                {
                    Console.WriteLine(item.Value);
                    break;
                }
                
            }
            foreach (var item in dic)
            {
                if (dic[item.Key] == "307-687-2982") { Console.WriteLine(item.Key); break; } 
                
            }

            foreach (var item in dic)
            {
                Console.WriteLine((dic.ContainsKey("Chris E. Myers")) ? "yes" : "no"); break;
            }


            Console.ReadKey();
        }
    }
}
