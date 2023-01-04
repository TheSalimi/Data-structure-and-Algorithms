using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');

            int n = int.Parse(a[0]);
            int m = int.Parse(a[1]);

            Graph graph = new Graph(n);

            for (int i = 0; i < m; i++)
            {
                a = Console.ReadLine().Split(' ');
                graph.AddEdges(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]));
            }

            Console.WriteLine(Math.Round(graph.LongestPath(), 3).ToString("N3"));
            Console.ReadKey();
        }


    }

    class Graph
    {
        int[,] edges;
        int n;

        public Graph(int n)
        {
            this.n = n;
            edges = new int[n, n];
        }

        public void AddEdges(int n1, int n2, int weight)
        {
            edges[n2, n1] = weight;
            edges[n1, n2] = weight;
        }

        public double LongestPath()
        {
            int i = 1;
            bool[] visited = new bool[n];

            double[] maxProbability = new double[n];
            maxProbability[0] = 1.0;
            
            while (i!=n)
            {
                visited[i] = false;
                maxProbability[i] = double.MinValue;
                i++;
            }

            for (int vercity = 0; vercity < n - 1; vercity++)
            {
                int maxIndex = MaxDistance(maxProbability, visited);
                i = 0;
                if (maxIndex == -1)
                    return 0;

                visited[maxIndex] = true;

                while (i != n)
                {
                    if (!visited[i]
                        && maxProbability[maxIndex] != int.MinValue
                        && edges[maxIndex, i] != 0
                        && maxProbability[maxIndex] * edges[maxIndex, i] / 100.0 > maxProbability[i])
                    {
                        maxProbability[i] = maxProbability[maxIndex] * edges[maxIndex, i] / 100.0;
                    }
                    i++;
                }
            }

            if (maxProbability[n - 1] == double.MinValue)
                return 0;

            return maxProbability[n - 1];
        }

        int MaxDistance(double[] maxProbability, bool[] visited)
        {
            double max = double.MinValue;
            int maxIndex = -1;
            int i = 0;
            while (i!=n)
            {
                if (!visited[i] && maxProbability[i] >= max)
                {
                    max = maxProbability[i];
                    maxIndex = i;
                }
                i++;
            }

            return maxIndex;
        }
    }
}
