using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching_Indexes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                (string.Join(",", findMatchingIndexes(1, new int[] { 1, 11, 34, 52, 61 })));
            Console.WriteLine
                            (string.Join(",", findMatchingIndexes(9, new int[] { 1, 11, 34, 52, 61 })));
            Console.ReadKey();
        }

        static int[] findMatchingIndexes(int givenNumber, int[] givenArray)
        {
            int counter = 0;
            var list = new List<int>();
            for (int i = 0; i < givenArray.Length; i++)
            {
                string convertedNumber = givenArray[i].ToString();

                if (convertedNumber.Contains(givenNumber.ToString()))
                {
                    list.Add(i);
                    counter++;

                }
            }
            int[] indexes = new int[counter];
            if (indexes.Length == list.Count)
            {

                for (int i = 0; i < indexes.Length; i++)
                {

                    indexes[i] = list[i];

                }
            }



            return indexes;
        }
    }
}
