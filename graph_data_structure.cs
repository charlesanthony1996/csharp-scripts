// What is a graph in data structure, and how can it be implemented? 
// Please give a concrete example


// What is a Graph in Data Structures?
// A graph is a non-linear data structure consisting of:

// Vertices (or nodes) – represent entities.

// Edges (or links) – represent connections or relationships between the vertices.



// Graphs can be:

// Directed (edges have direction)

// Undirected (edges have no direction)

// Weighted (edges have weights/costs)

// Unweighted



// Graph Terminology
// Adjacency: Two nodes are adjacent if they are connected by an edge.

// Degree: Number of edges connected to a node.

// Path: A sequence of nodes connected by edges.



// Graph Implementations
// There are two common ways to implement a graph:

// 1. Adjacency Matrix
// A 2D array used to represent a graph.

// Pros: Easy to implement, fast edge lookup.

// Cons: Wastes space for sparse graphs.



// 2. Adjacency List
// Each node stores a list of its neighbors.

// Pros: Space efficient for sparse graphs.

// Cons: Slower to check if an edge exists between two nodes.


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




//  Real-World Applications of Graphs
// Social networks (users and their connections)

// Google Maps (cities and roads)

// Recommendation systems (items and users)

// Computer networks (routers and links)