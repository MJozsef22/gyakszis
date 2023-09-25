using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Rotatematrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>
            {
                new List<int>{1,2,3 },
                new List<int> {4,5,6},
                new List<int> {7,8,9},
            };
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
                Console.WriteLine();
            }

            Console.WriteLine("   V   ");
            Console.WriteLine("   V   ");
            Console.WriteLine("   V   ");

            foreach (var item in RotateMatrix(matrix))
            {
                Console.WriteLine(string.Join(" ", item));
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static List<List<int>> RotateMatrix(List<List<int>> matrix)
        {
            int row = matrix.Count;
            int col = matrix[0].Count;

            var rotated = new List<List<int>>(col);

            for (int j = 0; j < col; j++)
            {
                List<int> newRow = new List<int>(row);
                for (int i = row - 1; i >= 0; i--)
                {
                    newRow.Add(matrix[i][j]);
                }
                rotated.Add(newRow);
            }

            return rotated;
        }
    }
}
