using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int missedNumber = search(array);
            Console.Write(missedNumber);
            Console.ReadKey();
        }

        private static int search(int[] array )
        {
            int left = 0, right = array.Length - 1;
            int diff = ((array[right]) - (array[left])) / array.Length;

            while (left <= right)
            {
                //find the middle index
                int middle = (right + left) / 2;
                /*if middle number is on middle index then search for the missing number from
                 middle + 1 index to end*/
                if ((array[middle] - array[0]) / diff == middle) left = middle + 1;
                //else start searching from index (0 to middle - 1)
                else right = middle - 1;
            }

            return array[right] + diff;
        }
    }
}
