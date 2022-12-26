using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = 0;

            string input = Console.ReadLine();

            bool Bool = false;

            CYKrules[,] strings = new CYKrules[input.Length, input.Length];


            for (int i = 0; i < input.Length; i++)
            {

                for (int j = i; j < input.Length; j++)
                {
                    strings[i, j] = new CYKrules();
                }

            }

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == 'a')
                {
                    strings[i, i].rules.Add('A');
                }
                else if (input[i] == 'b')
                {
                    strings[i, i].rules.Add('B');
                }
            }


            while (L < input.Length)
            {

                int a = 0;

                while (a < input.Length)
                {

                    int j = L + a;

                    if (j < input.Length)
                    {
                        int b = a;

                        while (b < j)
                        {

                            int c = 0;

                            while (c < strings[a, b].rules.Count)
                            {

                                int d = 0;

                                while (d < strings[b + 1, j].rules.Count)
                                {

                                    string m = strings[a, b].rules[c].ToString() + strings[b + 1, j].rules[d].ToString();

                                    if (m == "AB")
                                    {
                                        strings[a, j].rules.Add('S');
                                        strings[a, j].rules.Add('B');
                                    }
                                    else if (m == "BB")
                                    {
                                        strings[a, j].rules.Add('A');
                                    }

                                    d++;
                                }

                                c++;
                            }

                            b++;
                        }
                    }

                    a++;
                }

                L++;
            }

            for (int i = 0; i < strings[0, input.Length - 1].rules.Count; i++)
            {
                if (strings[0, input.Length - 1].rules[i] == 'S')
                {
                    Bool = true;
                    Console.WriteLine("Accepted");
                    break;
                }
            }
            if (Bool == false)
            {
                Console.WriteLine("Rejected");
            }

            Console.ReadKey();
        }



        class CYKrules
        {
            public List<char> rules = new List<char>();
        }
    }
}
