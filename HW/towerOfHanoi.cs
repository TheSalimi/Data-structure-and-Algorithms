using System;

namespace towerOfHonoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Move(3, 'A', 'B', 'C');
            Console.ReadKey();
        }

        public static void Move(int number , char source , char destination , char auxiliary)
        {
            if (number > 1)
            {
                Move(number - 1, source, auxiliary, destination);
                Move(1, source, destination, auxiliary);
                Move(number - 1, auxiliary, destination, source);
            }
            else
                Console.WriteLine($"Move the top disk from {source} to {destination}");
        }
    }
}
