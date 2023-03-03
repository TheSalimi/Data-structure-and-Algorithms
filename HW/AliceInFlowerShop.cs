using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxHeap
{
    class MaxHeap
    {
        public static void BuildHeap( int[]array)
        {
            int startIndex = array.Length / 2 + 1;

            for (int i = startIndex; i >= 0; i--)
            {
                heapify(array, array.Length, i);
            }
        }

        public static void heapify( int[] array, int size, int rootIndex)
        {
            int largest = rootIndex;
            int leftChild = 2 * rootIndex + 1;
            int rightChild = 2 * rootIndex + 2;

            if (leftChild < size && array[leftChild] > array[largest]) largest = leftChild;

            if (rightChild < size && array[rightChild] > array[largest]) largest = rightChild;

            if(rootIndex != largest)
            {
                int swap = array[rootIndex];
                array[rootIndex] = array[largest];
                array[largest] = swap;

                heapify( array, size , largest);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            int [] values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            MaxHeap.BuildHeap (values);

            int numberOfCoins = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCoins ; i++)
            {
                int max = values[0];

                total += max;

                values[0] = max / 2;

                MaxHeap.heapify( values, values.Length, 0);
            }

            total %= 1000000003;

            Console.Write(total);

            Console.ReadKey();
        }
    }
}
