using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class beolv
    {
        public string num1 { get; private set; }
        public string num2 { get; private set; }
        public string num3 { get; private set; }
        public string num4 { get; private set; }
        public string num5 { get; private set; }

        public beolv(string s)
        {
            var temp = s.Split(';');
            num1 = temp[11];
            num2 = temp[12];
            num3 = temp[13];
            num4 = temp[14];
            num5 = temp[15];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<beolv> data = new List<beolv>();
            var temp = File.ReadAllLines("lottery.csv");
            var result1 = new Dictionary<string, int>();
            var result = new Dictionary<string, int>();
            foreach (var item in temp)
            {
                data.Add(new beolv(item));
            }
            foreach (var item in data)
            {

                result = new Dictionary<string, int>(GetTheMostFrequentNumber(item.num1, item.num2, item.num3, item.num4, item.num5));
                foreach (var item1 in result)
                {
                    if (!result1.ContainsKey(item1.Key))
                    {
                        result1.Add(item1.Key, result[item1.Key]);
                    }
                    else
                    {
                        result1[item1.Key] += result[item1.Key];
                    }
                }
            }

            /*foreach (var item in result1)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }*/

            Console.WriteLine();
            var sortedDic = result1.OrderByDescending(x => x.Value).Take(5).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in sortedDic)
            {
                Console.WriteLine($"{item.Key}");
            }


            Console.ReadKey();
        }

        static Dictionary<string, int> GetTheMostFrequentNumber(string num1, string num2, string num3,
            string num4, string num5)
        {
            List<string> asd = new List<string>();
            asd.Add(num1);
            asd.Add(num2);
            asd.Add(num3);
            asd.Add(num4);
            asd.Add(num5);
            var dic = new Dictionary<string, int>();
            foreach (var item in asd)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
                else
                {
                    dic[item]++;
                }

            }

            return dic;
        }
    }
}
