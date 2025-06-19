// # singly linked list

// # a value (data)

// # a pointer (reference) to the next node in the list



// # key features

// # unidirectional

// # the last node's next pointer is null

// # insertion/deletion is efficient (especially at the beginning)

class node {
    public int data;
    public node next;

    public node(int data) {
        data = data;
        next = null;
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


class DNode{
    public int Data;
    public DNode Next;
    public DNode Prev;

    public DNode(int data) {
        Data = data;
        Next = Prev = null;
    }
}

