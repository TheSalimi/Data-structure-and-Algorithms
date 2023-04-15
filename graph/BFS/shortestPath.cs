using System;
using System.Collections;
using System.Collections.Generic;

class Node
{
	public string color;
	public int depth;
	public int parent;
	public int num;
	public Node(string color, int depth, int parent, int num)
	{
		this.color = color;
		this.depth = depth;
		this.parent = parent;
		this.num = num;
	}
}
class Graph
{
	private int V;
	private LinkedList<Node>[] adj;

	// Constructor
	Graph(int v)
	{
		V = v;
		adj = new LinkedList<Node>[v + 1];
		for (int i = 0; i <= v; ++i)
			adj[i] = new LinkedList<Node>();
	}

	// Function to add an edge into the graph
	void addEdge(int v, int w)
	{
		Node node = new Node("white", int.MaxValue, int.MinValue, w);
		adj[v].AddLast(node);
	}
	bool pathLength(int s, int d)
	{
		LinkedList<Node> queue = new LinkedList<Node>();
		Node start = new Node("gray", 0, -1, s);
		queue.AddLast(start);
		while (queue.Count != 0)
		{
			Node u = queue.First.Value;
			queue.RemoveFirst();
			foreach (Node vertex in adj[u.num])
			{
				if (vertex.num == d)
				{
					Console.WriteLine(u.depth + 1);
					return true;
				}
				if (vertex.color == "white")
				{
					vertex.color = "gray";
					vertex.depth = u.depth + 1;
					vertex.parent = u.num;
					queue.AddLast(vertex);
				}
			}
			u.color = "black";
		}
		return false;
	}

	public static void Main(string[] args)
	{

		int[] n_m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		int n = n_m[0];
		int m = n_m[1];
		List<List<int>> adj = new List<List<int>>(n);
		Graph g = new Graph(n);
		int i = 0;
		while (i != n)
		{
			adj.Add(new List<int>());
			i++;
		}

		i = 0;
		while (i != m)
		{
			int[] a_b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int a = a_b[0];
			int b = a_b[1];

			g.addEdge(a, b);
			i++;
		}

		int[] u_v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		int u = u_v[0];
		int v = u_v[1];

		if (!g.pathLength(u, v))
		{
			Console.WriteLine("no path");
		}
	}
}