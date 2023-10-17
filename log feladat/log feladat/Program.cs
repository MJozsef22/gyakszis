using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_feladat
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var temp = File.ReadAllLines("log.txt");
            List<log> data = new List<log>();
            foreach (var item in temp)
            {
                data.Add(new log(item));
            }

            //1 feladat
            var uniqueIp = new Dictionary<string, int>();
            StreamWriter wr = new StreamWriter("unique_addresses.txt");

            foreach (var item in data)
            {
                if (!uniqueIp.ContainsKey(item.IPAddress))
                { uniqueIp.Add(item.IPAddress, 1); }
                else { uniqueIp[item.IPAddress]++; }

            }

            foreach (var item in uniqueIp)
            {
                if (item.Value == 1)
                {
                    wr.WriteLine(item.Key);
                }
            }
            wr.Dispose();

            Console.WriteLine("Success!");


            //2 feladat
            int postCount = 0;
            foreach (var item in data)
            {
                if (item.Type == "POST")
                {
                    postCount++;
                }
            }
            double postPercentage = (double)postCount / (double)data.Count * 100;
            double getPercentage = 100 - postPercentage;
            Console.WriteLine($"POST: {postPercentage}%\nGET: {getPercentage}%");


            Console.ReadKey();
        }
    }
}
