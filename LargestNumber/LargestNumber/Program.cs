using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class LargestNumber
    {
        public static string FindLargestNumber(List<string> list)
        {
            string answer = "";
            string answer2 = "";
            list.Sort((a, b) => (a + b).CompareTo(b + a));
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
                answer = answer + list[i];

            if (answer[0] == 0 && answer.Length > 1)
                answer2 = "0";

            return (answer2 + answer);
        }

    }
    //0060
    //00
    //0907
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> numbers = new List<string>();

            for (int i = 0; i < n; i++) numbers.Add(Console.ReadLine());

            string answer = LargestNumber.FindLargestNumber(numbers);

            int start = 0;
            int ZeroCount = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] != '0')
                {
                    start = i;
                    break;
                }
                ZeroCount++;
            }
            if (ZeroCount == answer.Length)
                Console.Write(0);
            else if (start == 0)
                Console.Write(answer);
            else
                for (int i = start; i < answer.Length; i++)
                    Console.Write(answer[i]);
            
            Console.ReadKey();
        }
    }
}
