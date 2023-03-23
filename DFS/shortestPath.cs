using System;
using System.Collections.Generic;
namespace HW3_1
{
    class Program
    {
        static bool exit = false;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] adj = new List<int>[n+1];

            for (int i = 0; i <= n; i++)
                adj[i] = new List<int>();
            
            for (int i = 0; i < n-1; i++)
            {
                int[] a_b =Array.ConvertAll( Console.ReadLine().Split(), int.Parse);
                addEdge(a_b[0], a_b[1], adj);
            }
            int[] u_v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            DFS(u_v[0], -1, 0, u_v[1],adj);
        }

        static void addEdge(int a , int b , List<int>[]adj)
        {
            adj[a].Add(b);
            adj[b].Add(a);
        }

        static void DFS(int node,int parent,int level,int dest, List<int>[]adj)
        {
            if (node != dest)
            {
                foreach (int child in adj[node])
                {
                    if (child != parent)
                    {
                        DFS(child, node, level + 1, dest, adj);
                        if (exit)
                            return;
                    }
                }
            }
            else
            {
                Console.WriteLine(level);
                exit = true;
            }
        }
    }
}
