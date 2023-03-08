using System;

namespace hw16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n_m = Console.ReadLine().Split();
            int n = int.Parse(n_m[0]);
            int m = int.Parse(n_m[1]);
            int[] lengths = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] cost = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] revenue = new int[m+1];


            for (int i = 1; i <= m; i++)
            {
                int q = int.MinValue;
                for (int k = 0; k < i; k++)
                {
                    q = Math.Max(q, cost[k] + revenue[i - k - 1]);
                }
                revenue[i] = q;
            }

            Console.WriteLine(revenue[m]);
        }
    }
}
