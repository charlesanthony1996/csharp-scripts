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
        adjlist[vertex1].addvertex(vertex2);
    }

    public void printgraph() {
        Console.WriteLine("printing...");
    }

}

class Program {
    static void Main() {
        Graph g = new Graph();
        g.addedge(1,1);
        g.printgraph();
    }
}