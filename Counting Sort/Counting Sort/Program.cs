using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    class Program
    {
        static void CountSort(char[] arr)
        {
            int size = arr.Length;

            char[] outPut = new char[size];

            int[] count = new int[256];

            for (int i = 0; i < 256; i++)
                count[i] = 0;

            for (int i = 0; i < size; ++i)
                count[arr[i]] += 1;

            for (int i = 1; i <=255; ++i)
                count[i] += count[i - 1];

            for (int i = size-1; i >=0; i--)
            {
                outPut[count[arr[i]]-1] = arr[i];
                count[arr[i]]-=1;
            }

            for (int i = 0; i < size; i++)
                arr[i] = outPut[i];
        }
        static void Main(string[] args)
        {
           
        }
    }
}
