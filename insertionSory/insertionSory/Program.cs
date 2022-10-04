using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 10, 2, 6, 8, 6, 9, 3, 1 };
            Console.WriteLine("Before sort");
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            InsertionSort(ref array);

            Console.WriteLine("\nAfter sort");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }

        private static void InsertionSort(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = temp; ;

            }
        }

    }

  
}
