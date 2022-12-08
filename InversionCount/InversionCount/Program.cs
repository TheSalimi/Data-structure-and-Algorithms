using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(inversionCount(array, n));
            Console.ReadKey();
        }

        static int merge(int[] array, int[] temp, int left, int mid, int right)
        {
            int i, j, k;
            int inversionCount = 0;

            i = left;
            j = mid;
            k = left;

            while (i <= mid - 1 && j <= right)
            {
                if (array[i] <= array[j]) temp[k++] = array[i++];

                else
                {
                    temp[k++] = array[j++];
                    inversionCount = inversionCount + (mid - i);
                }
            }

            while (i <= mid - 1)
                temp[k++] = array[i++];

            while (j <= right)
                temp[k++] = array[j++];

            for (i = left; i <= right; i++)
                array[i] = temp[i];

            return inversionCount;
        }

        static int mergeSort(int[] arr, int[] temp, int left, int right)
        {
            int mid;
            int leftC = 0, rightC = 0, duringMergeC = 0;

            if (right > left)
            {
                mid = (right + left) / 2;

                leftC += mergeSort(arr, temp, left, mid);
                rightC += mergeSort(arr, temp, mid + 1, right);
                duringMergeC = merge(arr, temp, left, mid + 1, right);
            }

            return (leftC + rightC + duringMergeC);
        }

        static int inversionCount(int [] arr , int n)
        {
            int[] temp = new int[n];
            return mergeSort(arr, temp, 0, n - 1);
        }

    }
}
