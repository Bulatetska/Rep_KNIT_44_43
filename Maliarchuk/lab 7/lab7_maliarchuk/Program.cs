using System;

class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Vector operator -(Vector v)
    {
        return new Vector(-v.X, -v.Y);
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y;
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    public static Vector operator *(Vector v, double scalar)
    {
        return new Vector(v.X * scalar, v.Y * scalar);
    }

    public static Vector operator *(double scalar, Vector v)
    {
        return v * scalar; 
    }

    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    public void Print()
    {
        Console.WriteLine($"({X}, {Y})");
    }

    public override bool Equals(object obj)
    {
        if (obj is Vector v)
        {
            return this == v;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}

class Program
{
    static void Main()
    {
        Vector v1 = new Vector(3, 4);
        Vector v2 = new Vector(1, -2);

        Console.WriteLine("Початкові вектори:");
        Console.Write("v1: "); v1.Print();
        Console.Write("v2: "); v2.Print();

        Vector v1Negative = -v1;
        Console.WriteLine("\nПісля застосування унарного мінуса до v1:");
        v1Negative.Print();

        Vector vSum = v1 + v2;
        Console.WriteLine("\nСума v1 та v2:");
        vSum.Print();

        Vector v2Scaled = v2 * 2;
        Console.WriteLine("\nМноження v2 на скаляр 2:");
        v2Scaled.Print();

        Console.WriteLine("\nПорівняння векторів:");
        Console.WriteLine($"v1 == v2: {v1 == v2}");
        Console.WriteLine($"v1 != v2: {v1 != v2}");

        Console.WriteLine("\nДовжина вектора v1:");
        Console.WriteLine(v1.Length());
    }
}
