using System;
using System.Collections.Generic;


class Program {
    static void Main() {
        Console.WriteLine("Hello");

        Graph g = new Graph();

        g.addedge("A", "B");
        g.addedge("A", "C");
        g.addedge("B", "C");

        g.printgraph();
        g.vertexcount();
    }
}


class Graph {
    public Dictionary<string, List<string>> adjlist;

    public Graph() {
        adjlist = new Dictionary<string, List<string>>();
    }

    public void addvertex(string vertex) {
        if (!adjlist.ContainsKey(vertex)) {
            adjlist[vertex] = new List<string>();
        }
    }

    public void addedge(string vertex1, string vertex2) {
        addvertex(vertex1);
        addvertex(vertex2);
        adjlist[vertex1].Add(vertex2);
    }

    public int vertexcount() {
        return adjlist.Count;
    }

    public void printgraph() {
        foreach (var vertex in adjlist) {
            Console.Write(vertex.Key + " -> ");
            Console.WriteLine(string.Join(", ", vertex.Value));
        }
    }
}


// | Property             | Value                        |
// | -------------------- | ---------------------------- |
// | **Type**             | Undirected (can be directed) |
// | **Storage**          | Adjacency List               |
// | **Vertices (Nodes)** | Unique strings               |
// | **Edges**            | Unweighted                   |
// | **Operations**       | Add vertex, Add edge, Count  |
