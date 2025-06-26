using System;
using System.Collections.Generic;

class Graph {
    private Dictionary<int, List<int>> adjlist;

    public Graph() {
        adjlist = new Dictionary<int, List<int>>();
    }

    // add a vertex
    public void addvertex(int vertex) {
        if (!adjlist.ContainsKey(vertex)) {
            adjlist[vertex] = new List<int>();
        }
    }

    public void addedge(int vertex1, int vertex2) {
        addvertex(vertex1);
        addvertex(vertex2);
        adjlist[vertex1].Add(vertex2);
        adjlist[vertex2].Add(vertex1);
    }

    public void printgraph() {
        foreach(var vertex in adjlist) {
            Console.Write($"{vertex.Key} -> ");
            foreach(var neighbor in vertex.Value) {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }

}

class Program {
    static void Main() {
        Graph g = new Graph();
        g.addedge(1, 2);
        g.addedge(1, 3);
        g.addedge(2, 4);
        g.addedge(3, 4);
        g.addedge(4, 5);



        g.printgraph();
    }
}