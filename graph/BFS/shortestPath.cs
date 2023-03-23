using System;
using System.Collections.Generic;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n_m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int>[] adj = new List<int>[n_m[1]];

            for (int i = 0; i < n_m[1]; i++)
                adj[i] = new List<int>();

            for (int i = 0; i < n_m[1]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                addEdge(input[0], input[1], adj);
            }

            int[] u_v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int level = 0;
            Queue<int> queue = new Queue<int>();
            HashSet<int> visitedNodes = new HashSet<int>();
            queue.Enqueue(u_v[0]);
            visitedNodes.Add(u_v[0]);
            bool addLevel = false;
            bool found = false;
            while (queue.Count != 0)
            {
                addLevel = false;
                int state = queue.Dequeue();
                foreach (int vert in adj[state])
                {
                    if (vert == u_v[1])
                    {
                        found = true;
                        addLevel = true;
                    }
                    else if (!visitedNodes.Contains(vert))
                    {
                        queue.Enqueue(vert);
                        visitedNodes.Add(vert);
                        addLevel = true;
                    }
                }

                visitedNodes.Add(state);

                if (addLevel)
                    level++;

                if (found)
                    break;
            }
            if (!found)
                Console.WriteLine("no path");
            else
                Console.WriteLine(level);
        }

        static void addEdge(int a, int b, List<int>[] adj)
        {
            adj[a].Add(b);
        }
    }
}
