using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChanging_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int[]coins = { 1,3,4};
            Console.WriteLine(MinCoins(m, coins, coins.Length));
            Console.ReadKey();
        }

        static int MinCoins(int total , int[]coins , int length)
        {
            int[] minNumOfCoins = new int[total + 1];
            minNumOfCoins[0] = 0;

            for (int i = 1; i <= total; i++)
                minNumOfCoins[i] = int.MaxValue;

            for (int i = 1; i <= total; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if(coins[j] <= i)
                    {
                        int sub = minNumOfCoins[i - coins[j]];
                        if (sub != int.MaxValue && sub + 1 < minNumOfCoins[i])
                            minNumOfCoins[i] = sub + 1;
                    }
                }
            }

            return minNumOfCoins[total];
        }
    }
}
