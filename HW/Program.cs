using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2_6
{
    class Program
    {
        static void Main()
        {
            int[] N_X_Y = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] chargesArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> charges = new List<int>();
            charges.AddRange(chargesArr);

            int n = N_X_Y[0];
            int x = N_X_Y[1];
            int y = N_X_Y[2];
            int count = 0;

            for (int i = 0; i < n && count<n-1 ; i++)
            {
                int max = charges.Max();
                int min = charges.Min();
                while (max >= 100)
                {
                    charges.Remove(max);
                    max = charges.Max();
                    count++;
                }
                int tempMax = max;
                int tempMin = min;

                while (tempMin - x >= 0 && tempMax < 100)
                {
                    tempMin -= x;
                    tempMax += y;

                    if (tempMax >= 100)
                    {
                        charges.Remove(max);
                        charges.Remove(min);
                        charges.Add(tempMin);
                        count++;
                        break;
                    }
                }
            }

            if (count >= n - 1) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
