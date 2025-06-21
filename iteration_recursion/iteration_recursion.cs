using System;

// fibonacci using iteration

// iteration

// definition -> using looping constructs like for, while and do - while

// how it works -> the code executes repeatedly until a condition is no longer met

// Pros 
// -> usually more memory efficient in terms of memory and speed
// -> avoids the overhead of function calls

// Cons
// -> sometimes harder to write for problems naturally defined recursively (tree traversal)


class Program {
    public static void Main() {

        // FibonacciIterative(4);
        int result = FibonacciIterative(6);
        Console.Write(result);
    }

    public static int FibonacciIterative(int n) {
        if (n <= 1) return n;
        int a = 0, b = 1, result = 0;
        for (int i = 2; i <= n; i++) {
            result = a + b;
            a = b;
            b = result;
        }
    return result;
    }
}


// recursion

// definition -> a function that calls itself to solve a smaller version of the same problem

// how it works -> the problem is broken down into smaller sub problems until a base case is reached

// pros
// -> easier to read and write for problems that are naturally recursive (like factorial, tree structures)

// cons
// -> less efficient due to multiple function calls and risk of stack overflow

using System;

class Program {
    public static void Main() {
        int result = FibonacciRecursive(6);
        Console.Write(result);
    }

    public static int FibonacciRecursive(int n) {
        if (n <=1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
}
