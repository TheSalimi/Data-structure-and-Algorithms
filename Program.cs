using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] arrayStr = new string[input];
            arrayStr = Console.ReadLine().Split(' ');

            int missedNumber = search(arrayStr);
            Console.Write(missedNumber);
            Console.ReadKey();
        }

        private static int search(string[]array )
        {
            if (array.Length == 2)
                return (int.Parse(array[0]) + int.Parse(array[1])) / 2;

            int space, spaceTemp;
            space = int.Parse(array[1]) - int.Parse(array[0]);
            spaceTemp = int.Parse(array[2]) - int.Parse(array[1]);
            if (space != spaceTemp) space = Math.Abs(space - spaceTemp);
        
            int left = 0 ,  right = array.Length - 1 , middle = 0;
            while (left < right)
            {
                middle = (right + left) / 2;
                //if middle element isn't on middle index , then missing element is middle + space
                if (int.Parse(array[0]) + middle * space != int.Parse(array[middle])) return int.Parse(array[0]) + middle * space;
                //if the element is not on the left => continue searching from middle to right
                if (int.Parse(array[middle]) == int.Parse(array[0]) + (middle) * space) left = middle + 1;
                else right = middle - 1;
            }

            return int.Parse(array[middle]) + space;
        }
    }
}
