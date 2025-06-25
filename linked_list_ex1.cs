// # singly linked list

// # a value (data)

// # a pointer (reference) to the next node in the list



// # key features

// # unidirectional

// # the last node's next pointer is null

// # insertion/deletion is efficient (especially at the beginning)

class Node {
    public int Data;
    public Node Next;

    public Node(int data) {
        this.Data = data;
        this.Next = null;
    }
}

// # doubly linked list

// # similar to a singly linked list, but each node has

// # a value

// # a pointer to the next node

// # a pointer to the previous node

// # key features

// # bi directional traversal (forward and backward)

// # requires more memory (extra pointer)

// # easier to delete or insert at both ends


class DNode {
    public int Data;
    public DNode Next;
    public DNode Prev;

    public DNode(int data) {
        Data = data;
        Next = Prev = null;
    }
}



// using Node and inheritance to create double Node for a doubly linked list

class DNode : Node {
    public DNode Prev;

    public DNode(int data) : base(data) {
        Prev = null;
    }
}


// remember to comment out one DNode class and run the script -> dotnet script linked_list_ex1.cs
