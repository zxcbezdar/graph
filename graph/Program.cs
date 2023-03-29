using System;
using System.Collections.Generic;

class Graph
{
    private List<List<int>> graph;

    public Graph()
    {
        graph = new List<List<int>>();
    }

    public void AddVertex()
    {
        graph.Add(new List<int>());
    }

    public void AddEdge(int u, int v)
    {
        graph[u].Add(v);
        graph[v].Add(u);
    }

    public void PrintGraph()
    {
        for (int i = 0; i < graph.Count; i++)
        {
            Console.Write(i + ": ");
            for (int j = 0; j < graph[i].Count; j++)
            {
                Console.Write(graph[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph g = new Graph();

         Console.Write("количество вершин: ");
        int n = int.Parse(Console.ReadLine());

       
        for (int i = 0; i < n; i++)
        {
            g.AddVertex();
        }

        
        Console.WriteLine("ребра (u v):");
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            string[] parts = input.Split(' ');
            int u = int.Parse(parts[0]);
            int v = int.Parse(parts[1]);
            g.AddEdge(u, v);
        }

        // вывод графа на экран
        Console.WriteLine("Граф:");
        g.PrintGraph();
    }
}
