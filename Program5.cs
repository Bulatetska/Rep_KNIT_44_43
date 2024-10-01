using System;

class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    // Конструктор, який ініціалізує координати вектора
    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Унарний мінус (-) для зміни знаків координат вектора
    public static Vector operator -(Vector v)
    {
        return new Vector(-v.X, -v.Y);
    }

    // Бінарний оператор додавання (+) для додавання двох векторів
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    // Оператор рівності (==) для порівняння двох векторів
    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y;
    }

    // Оператор нерівності (!=) для порівняння двох векторів
    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    // Оператор множення (*) для скалярного добутку
    public static double operator *(Vector v1, Vector v2)
    {
        return v1.X * v2.X + v1.Y * v2.Y;
    }

    // Метод для отримання довжини вектора
    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    // Метод для виведення вектора на екран
    public void Print()
    {
        Console.WriteLine($"Vector({X}, {Y})");
    }

    // Перевизначення методів Equals і GetHashCode (рекомендовано при перевантаженні операторів == та !=)
    public override bool Equals(object obj)
    {
        if (obj is Vector)
        {
            Vector v = (Vector)obj;
            return X == v.X && Y == v.Y;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        // Створення векторів
        Vector v1 = new Vector(3, 4);
        Vector v2 = new Vector(1, 2);
        Vector v3 = new Vector(3, 4);

        // Виведення векторів
        v1.Print();
        v2.Print();

        // Унарний мінус
        Vector v4 = -v1;
        Console.Write("Unary minus of v1: ");
        v4.Print();

        // Додавання векторів
        Vector v5 = v1 + v2;
        Console.Write("v1 + v2: ");
        v5.Print();

        // Оператор рівності та нерівності
        Console.WriteLine($"v1 == v2: {v1 == v2}");
        Console.WriteLine($"v1 == v3: {v1 == v3}");
        Console.WriteLine($"v1 != v2: {v1 != v2}");

        // Оператор множення (скалярний добуток)
        double scalarProduct = v1 * v2;
        Console.WriteLine($"v1 * v2 (dot product): {scalarProduct}");

        // Довжина вектора
        Console.WriteLine($"Length of v1: {v1.Length()}");
        Console.WriteLine($"Length of v2: {v2.Length()}");
    }
}