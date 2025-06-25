// What is the difference between function overloading and function overriding?



// The key difference between function overloading and function overriding lies in when and how they are used in object-oriented programming 
// (especially in languages like C++, Java, C#):


// Function Overloading (Compile-time / Static Polymorphism)
// Definition:
// Multiple functions with the same name but different parameter lists (type, number, or order) defined within the same class.

// 🔹 Key Points:
// Happens within a single class.

// Parameters must differ in number or type.

// Return type alone cannot distinguish overloaded functions.

// Resolved at compile time.

class Printer {
public:
    void print(int i) {
        cout << "Printing int: " << i << endl;
    }
    void print(double d) {
        cout << "Printing double: " << d << endl;
    }
};


// Function Overriding (Run-time / Dynamic Polymorphism)
// Definition:
// A derived class provides a new implementation of a method that is already defined in its base class, using the same signature.

// 🔹 Key Points:
// Involves inheritance (base and derived classes).

// The function in base class must be virtual (in C++) or overridden using a keyword (override in C# / Java).

// Parameters and return type must match exactly.

// Resolved at runtime.

class Animal {
public:
    virtual void speak() {
        cout << "Animal sound" << endl;
    }
};

class Dog : public Animal {
public:
    void speak() override {
        cout << "Bark" << endl;
    }
};

// | Feature              | Overloading                       | Overriding                            |
// | -------------------- | --------------------------------- | ------------------------------------- |
// | Inheritance Needed?  | ❌ No                              | ✅ Yes                                 |
// | Same Signature?      | ❌ No (parameters differ)          | ✅ Yes (parameters + return type same) |
// | Return Type Matters? | ❌ No (cannot differ alone)        | ✅ Yes (must match or be covariant)    |
// | When Resolved?       | 🛠️ Compile-time                  | 🕒 Runtime                            |
// | Purpose              | Improve readability & flexibility | Change behavior in subclass           |

