namespace _217_find_duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1,2,4,5,6,7,8,1];
            HashSet<int> set = new HashSet<int>();
            
            foreach(int a in arr)
            {
                if (set.Contains(a))
                {
                    Console.WriteLine($"duplicate : {a}");
                    break;
                }
                set.Add(a);
            }
        }
    }
}
