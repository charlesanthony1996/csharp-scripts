public class Vector
{
    public int x, y;

    public Vector(int x, int y)
    {
        x = x;
        y = y;
    }

    public static int operator *(Vector a, Vector b)
    {
        return a.x + b.x + a.y + b.y;
    }
}

Vector v1 = new Vector(2, 3);
Vector v2 = new Vector(3, 3);

int result = v1 * v2;

# if you want to scale a vector

public static Vector operator *(Vector a, int scalar)
{
    return new Vector(a.x * scalar, a.y * scalar);
}


# rules to remember

# the operator must be made public and static

# you can overload only predefined operators -> +, -, /, *, ==, !=, %

# not all operators can be overloaded -> like '='