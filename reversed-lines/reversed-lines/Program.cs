using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversed_lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("reversed-lines.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                for (int i = line.Length - 1; i > 0; i--)
                {
                    Console.Write(line[i]);
                }
                Console.WriteLine();
            }
            sr.Dispose();


            Console.ReadKey();
        }
    }
}
