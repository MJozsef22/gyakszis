using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betelepito
{
    internal class Program
    {
        class beolv
        {
            public string name { get; private set; }
            public string type { get; private set; }
            public DateTime date { get; private set; }
            public int year { get; private set; }
            public int month { get; private set; }
            public int day { get; private set; }
            public beolv(string s)
            {
                var temp = s.Split(';');
                name = temp[0];
                type = temp[1];
                year = int.Parse(temp[2].Split('-')[0]);
                month = int.Parse(temp[2].Split('-')[1]);
                day = int.Parse(temp[2].Split('-')[2]);
                date = new DateTime(year, month, day);
            }


        }
        static void Main(string[] args)
        {
            List<beolv> data = new List<beolv>();
            foreach (var item in File.ReadAllLines("building_usage.txt").Skip(1))
            {
                data.Add(new beolv(item));
            }

            //1 feladat

            HashSet<string> names = new HashSet<string>();
            foreach (var item in data)
            {
                names.Add(item.name);
            }

            Console.WriteLine(names.Count);

            //2 feladat

            int count = 0;
            var dic = new Dictionary<string, string>();
            foreach (var item in data)
            {
                if (!dic.ContainsKey(item.name))
                {
                    dic.Add(item.name, item.type);
                    if (item.type == "student")
                        count++;
                }
            }

            double avg = Math.Round(((double)count / (double)names.Count) * 100, 2);
            Console.WriteLine(avg + " %");

            //3 feladat

            Dictionary<DateTime, int> temp1 = new Dictionary<DateTime, int>();

            foreach (var item in data)
            {
                if (!temp1.ContainsKey(item.date))
                { temp1.Add(item.date, 1); }
                else
                {
                    temp1[item.date]++;
                }
            }

            int max = int.MinValue;
            DateTime date = DateTime.MinValue;
            DateTime date1 = DateTime.MinValue;
            foreach (var item in temp1)
            {
                if (max < temp1[item.Key])
                {
                    max = temp1[item.Key];
                    date = item.Key;
                }
            }

            foreach (var item in temp1)
            {
                if (max == temp1[item.Key])
                { date1 = item.Key; }
            }



            Console.WriteLine(date);
            if (date1 > DateTime.MinValue && date1 != date)
            {
                Console.WriteLine(date1);
            }

            Console.ReadKey();
        }
    }
}
