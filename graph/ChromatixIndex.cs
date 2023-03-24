using System;
class Program
{
    static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine());
        int[,] edge = new int[n - 1, 2];

        for (int i = 0; i < n - 1; i++)
        {
            string inp = Console.ReadLine();
            edge[i, 0] = int.Parse(inp.Split()[0]);
            edge[i, 1] = int.Parse(inp.Split()[1]);
        }

        int max = 0;
        for (int i = 0; i < n - 1; i++)
            if (edge[i, 1] > max)
                max = edge[i, 1];

        int[] a = new int[max + 1];
        for (int i = 0; i <= max; i++)
            a[i] = 0;

        for (int i = 0; i < n - 1; i++)
            a[edge[i, 0]]++;

        for (int i = 0; i < n - 1; i++)
            a[edge[i, 1]]++;

        int ans = 0;
        for (int i = 0; i <= max; i++)
            if (a[i] > ans)
                ans = a[i];

        Console.WriteLine(ans);
    }
}
