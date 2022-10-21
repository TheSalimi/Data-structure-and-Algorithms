using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 6, 5, 3, 9 };
            int left = 0;
            int right = array.Length - 1;
            int[] sortedArray = sortArray(array, left, right);
            printArray(sortedArray);
            Console.ReadKey();
        }

        static int[] sortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                sortArray(array, left, middle);
                sortArray(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
            return array;
        }

        static void Merge(int[] array, int left, int middle, int right)
        {
            //Size of two subarrays to be merged
            int leftArraySize = middle - left + 1;
            int rightArraySize = right - middle;

            //Temp arrays
            int[] leftGroup = new int[leftArraySize];
            int[] rightGroup = new int[rightArraySize];

            //Copy data to temp arrays
            CopyDataToTempArrays(array, ref leftGroup, ref rightGroup, left, middle);

            //comapare left and right nums and sort
            int i = 0, j = 0, k = left;
            mergeRightAndLeft(ref array, rightGroup, leftGroup, ref i, ref j, ref k);

            //copy remained elements into the merged array
            remainedElements(ref array, rightGroup, leftGroup, i, j, k);
        }

        static void CopyDataToTempArrays(int[] array, ref int[] leftArray, ref int[] rightArray, int left, int middle)
        {
            for (int i = 0; i < leftArray.Count(); i++)
            {
                leftArray[i] = array[left + i];
            }

            for (int i = 0; i < rightArray.Count(); i++)
            {
                rightArray[i] = array[middle + 1 + i];
            }
        }

        static void mergeRightAndLeft(ref int[] array, int[] rightArray, int[] leftArray, ref int i, ref int j, ref int k)
        {
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j]) array[k++] = leftArray[i++];
                else array[k++] = rightArray[j++];
            }
        }

        static void remainedElements(ref int[] array, int[] rightArray, int[] leftArray, int i, int j, int k)
        {
            while (i < leftArray.Length) array[k++] = leftArray[i++];
            while (j < rightArray.Length) array[k++] = rightArray[j++];
        }

        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }
    }
}
