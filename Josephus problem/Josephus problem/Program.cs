using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Josephus_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int survivor = FIFO(13, 2);
            //Console.WriteLine(Recursion(13));
            Console.WriteLine($"{survivor}");
            Console.ReadKey();
        }


        public static int Recursion(int n)
        {

            if (n == 1)
            {
                return 1;
            }
            return (Recursion(n - 1) + 1) % n + 1;
        }

        public static int FIFO(int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }
            /*Queue<int> Josephus_member = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                Josephus_member.Enqueue(i);
            }

            while (Josephus_member.Count > 1)
            {
                for (int i = 0; i < k - 1; i++)
                {
                    int person = Josephus_member.Dequeue();
                    Josephus_member.Enqueue(person);
                }

                Josephus_member.Dequeue();
            }

            return Josephus_member.Dequeue();*/
            return (FIFO(n - 1, k) + k - 1) % n + 1;
        }
    }
}

