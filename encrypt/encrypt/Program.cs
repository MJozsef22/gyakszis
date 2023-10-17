using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace encrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temp = File.ReadAllLines("encrypted_lines.txt");
            foreach (var item in temp)
            {

                encryption(item);

            }

            Console.ReadKey();
        }

        static void encryption(string input)
        {
            List<string> encryptedText = new List<string>();

            foreach (char c in input)
            {
                if (c != ' ')
                {
                    char shiftedChar = (char)(c - 1);

                    encryptedText.Add(shiftedChar.ToString());
                }
                else
                    encryptedText.Add(c.ToString());
            }

            foreach (var item in encryptedText)
            {
                Thread.Sleep(60);
                Console.WriteLine(string.Join("", encryptedText));
                break;
            }



        }


    }
}
