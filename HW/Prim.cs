using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Graph graph = new Graph(n);

            int[,] verticies = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                verticies[i, 0] = int.Parse(row.Split(' ')[0]);
                verticies[i, 1] = int.Parse(row.Split(' ')[1]);
            }
            graph.InitializeEdges(verticies);
            graph.Prim();

            Console.ReadKey();
        }
    }

    class Graph
    {
        int n;
        int[,] edges;
        public Graph(int n)
        {
            this.n = n;
            edges = new int[n, n];
        }

        public void InitializeEdges(int[,] verticies)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    edges[i, j] = Math.Abs(verticies[i, 0] - verticies[j, 0]) + Math.Abs(verticies[i, 1] - verticies[j, 1]);
        }

        public void Prim()
        {
            bool[] visited = new bool[n];
            visited[0] = true;
            int visitedCount = 1;
            int sum = 0;

            while (visitedCount != n)
            {
                int min = int.MaxValue;
                int index = -1;

                for (int i = 0; i < n; i++)
                {
                    if (!visited[i])
                        continue;

                    for (int j = 0; j < n; j++)
                    {
                        if (edges[i, j] < min && !visited[j])
                        {
                            index = j;
                            min = edges[i, j];
                        }
                    }
                }
                visitedCount++;
                visited[index] = true;
                sum += min;
            }
            Console.WriteLine( sum );
        }
    }
}
