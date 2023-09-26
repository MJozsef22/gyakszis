using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlFixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            url = url.Replace("bot", "odd").Insert(url.IndexOf('/'),":");
            
            Console.WriteLine(url);


            Console.ReadKey();
        }
    }
}
