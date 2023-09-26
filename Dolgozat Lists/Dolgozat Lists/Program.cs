using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5, 6, 7 };
            int sum = 0;
            foreach (int number in numbers) { sum += number; }

            Console.WriteLine(sum);
            for (int i = numbers.Length-1; i>=0;i--)
            {
                Console.Write(numbers[i] + ";");
            }

            string text = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine();

            Console.WriteLine(maganhangzoSzamolas(text) +"\n");
            foreach (var item in dic) 
            {
                Console.WriteLine($"{item.Key} --> {dic[item.Key]}");
            }

            int[] array = { 5, 6, 0, -1 };


            for (int i = 0; i < avg(array).Count; i++)
            {
                Console.WriteLine($"{avg(array)[i]} %");
            }

            Console.ReadKey();
        }

        static public Dictionary<string,int> dic = new Dictionary<string,int>();
        static int maganhangzoSzamolas(string a)
        { 
            int maganhanzo = 0;
            char[] chars = a.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'a':
                        maganhanzo++;
                        if (!dic.ContainsKey("a"))
                        {
                            dic.Add("a",1);
                        }
                        else
                        {
                            dic[a]++;
                        }
                        break;
                    case 'e':
                        maganhanzo++;
                        if (!dic.ContainsKey("e"))
                        {
                            dic.Add("e", 1);
                        }
                        else
                        {
                            dic["e"]++;
                        }
                        break;
                    case 'i':
                        maganhanzo++;
                        if (!dic.ContainsKey("i"))
                        {
                            dic.Add("i", 1);
                        }
                        else
                        {
                            dic["i"]++;
                        }
                        break;
                    case 'o':
                        maganhanzo++;
                        if (!dic.ContainsKey("o"))
                        {
                            dic.Add("o", 1);
                        }
                        else
                        {
                            dic["o"]++;
                        }
                        break;
                    case 'u':
                        maganhanzo++;
                        if (!dic.ContainsKey("u"))
                        {
                            dic.Add("u", 1);
                        }
                        else
                        {
                            dic["u"]++;
                        }
                        break;
                    default:
                        break;
                }
            }
            return maganhanzo;
        }

        static List<double> avg(int[] a)
        {
            List<double> result = new List<double>();
            double poz = 0;
            double neg = 0;
            double nul = 0;
            foreach (int item in a) 
            {
                if (item>0)
                {
                    poz++;
                }
                else if (item == 0) { nul++; }
                else { neg++; }
            }
            
            result.Add(poz =(poz/a.Length)*100);
            result.Add(neg=(neg/a.Length)*100);
            result.Add(nul=(nul/a.Length)*100);
            return result;
        }
    }
}
