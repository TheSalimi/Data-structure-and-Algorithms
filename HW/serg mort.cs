using System;
using System.Collections.Generic;
namespace hw18
{
    class Program
    {
        static void Main()
        {
            int[] n_k = Array.ConvertAll(Console.ReadLine().Split() , int.Parse);
            int n = n_k[0];
            int k = n_k[1];
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse); ;
            long[,] cost = new long[k, k];

            for (int i = 0; i < k; i++) 
                cost[i, i] = 0;
            for (int length = 1; length < k; length++)
            {
                for (int i = 0; i < k - length; i++)
                {
                    int j = i + length;

                    if (j < k)
                    {
                        long sum = 0;
                        for (int s = i; s <= j; s++)    
                            sum += arr[s];

                        for (int a = i; a < j; a++)
                        {
                            if (cost[i, j] != 0)
                                cost[i, j] = Math.Min(cost[i, j], sum + cost[i, a] + cost[a + 1, j]);
                            else
                                cost[i, j] = sum + cost[i, a] + cost[a + 1, j];

                        }
                    }

                }
            }
            Console.WriteLine(cost[0, k - 1]);
        }

    }
}
