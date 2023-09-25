using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = Create(20);
            print(matrix);

            Console.ReadKey();
        }

        public static int[,] Create(int size)
        {
            int[,] temp = new int[size,size];
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        temp[i, j] = 1;
                    }
                    else
                    {
                        temp[i, j] = 0;
                    }
                }
            }
            return temp;
        }

        public static void print(int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] );
                }
                Console.WriteLine();
            }
        }
    }
}
