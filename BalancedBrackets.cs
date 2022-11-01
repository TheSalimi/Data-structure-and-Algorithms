using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static bool checkPairMatch(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')') return true;
            else if (character1 == '{' && character2 == '}') return true;
            else if (character1 == '[' && character2 == ']') return true;
            else return false;
        }

        static int checkBracketsBalance(List<char> bracketes)
        {
            int counter = -1;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < bracketes.Count; i++)
            {
                if (bracketes[i] == '{' || bracketes[i] == '[' || bracketes[i] == '(')
                {
                    stack.Push(bracketes[i]);
                    if (stack.Count == 1)
                    {
                        counter = i + 1;
                    }
                }

                if (bracketes[i] == '}' || bracketes[i] == ')' || bracketes[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return i + 1;
                    }
                    else if (!checkPairMatch(stack.Pop(), bracketes[i]))
                    {
                        return i + 1;
                    }
                }
            }

            if (stack.Count == 0) return -1;
            else
            {
                return counter;
            }
        }

        static List<char> extractBracketsFromText(string input, out List<int> IndexesOfBrackets)
        {
            int counter = -1;
            List<char> brackets = new List<char>();
            IndexesOfBrackets = new List<int>();

            foreach (char character in input)
            {
                counter++;
                if (character == ']' || character == '}' || character == ')'
                    || character == '[' || character == '{' || character == '(')
                {
                    brackets.Add(character);
                    IndexesOfBrackets.Add(counter);
                }
            }
            return brackets;
        }

        static void Main(string[] args)
        {
            List<int> IndexesOfBrackets = new List<int>();
            string input = Console.ReadLine();
            int IndexOfMismatchInBrackets = checkBracketsBalance(extractBracketsFromText(input,out IndexesOfBrackets));
            if (IndexOfMismatchInBrackets == -1) Console.Write(-1);
            else
            {
                int outPut = IndexesOfBrackets[IndexOfMismatchInBrackets-1] + 1;
                Console.Write(outPut);
            }
            Console.ReadKey();
        }
    }
}
