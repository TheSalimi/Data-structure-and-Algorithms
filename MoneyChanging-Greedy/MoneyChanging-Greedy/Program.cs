using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChanging_Greedy
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            while (m > 0)
            {
                if (m >= 10)
                {
                    count++;
                    m -= 10;
                }
                else if (m < 10 && m >= 5)
                {
                    count++;
                    m -= 5;
                }
                else
                {
                    count++;
                    m -= 1;
                }
            }
            Console.Write(count);
            Console.ReadKey();
        }
    }
}
