using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_data_base
{
    internal class Program
    {
        static List<string> list = new List<string>();
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            dic.Add("egg", 200);
            dic.Add("milk", 200);
            dic.Add("fish", 400);
            dic.Add("apples", 150);
            dic.Add("bread", 50);
            dic.Add("chicken", 550);

            list.Add((dic["fish"]).ToString());

            int a = int.MinValue;
            foreach (var item in dic)
            {
                if (a < dic[item.Key])
                {
                    a = dic[item.Key];
                }
            }
            list.Add((a).ToString());

            int sum = 0;

            foreach (var item in dic)
            {
                sum += dic[item.Key];
            }
            list.Add((sum / dic.Count).ToString());

            int count = 0;
            foreach (var item in dic)
            {
                if (dic[item.Key] <300)
                {
                    count++;
                }
            }

            list.Add((count).ToString());

            string str = string.Empty;
            foreach (var item in dic)
            {
                if (dic[item.Key] == 125)
                {
                    str = "yes";
                }
                else
                {
                    str = "no";
                }
            }
            list.Add((str).ToString());

            int b = int.MaxValue;
            foreach (var item in dic)
            {
                if (b > dic[item.Key])
                {
                    b= dic[item.Key];
                }
            }

            list.Add((b).ToString());

            foreach (string item in list)
            {
                Console.WriteLine(item + ";");
            }

            Console.ReadKey();
        }
    }
}
