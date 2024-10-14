using System;

class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    // Конструктор
    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Унарний мінус (зміна знаків координат)
    public static Vector operator -(Vector v)
    {
        return new Vector(-v.X, -v.Y);
    }

    // Бінарний оператор додавання (додавання відповідних координат)
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    // Оператор рівності (вектори рівні, якщо координати однакові)
    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y;
    }

    // Оператор нерівності
    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    // Оператор множення (множення вектора на скаляр)
    public static Vector operator *(Vector v, double scalar)
    {
        return new Vector(v.X * scalar, v.Y * scalar);
    }

    // Метод для виведення вектора на екран
    public void Print()
    {
        Console.WriteLine($"Vector({X}, {Y})");
    }

    // Метод для отримання довжини вектора
    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    // Перевизначення Equals і GetHashCode для коректної роботи операторів == і !=
    public override bool Equals(object obj)
    {
        if (obj is Vector)
        {
            Vector v = (Vector)obj;
            return this == v;
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
    static void Main(string[] args)
    {
        // Створення двох векторів
        Vector v1 = new Vector(3, 4);
        Vector v2 = new Vector(1, -2);

        // Зміна знаків координат вектора v1
        Vector v1Neg = -v1;
        Console.WriteLine("v1 зі зміненими знаками:");
        v1Neg.Print();

        // Додавання векторів v1 і v2
        Vector v3 = v1 + v2;
        Console.WriteLine("v1 + v2:");
        v3.Print();

        // Множення вектора v2 на скаляр 2
        Vector v2Mult = v2 * 2;
        Console.WriteLine("v2 * 2:");
        v2Mult.Print();

        // Порівняння векторів на рівність
        bool areEqual = v1 == v2;
        Console.WriteLine($"v1 == v2: {areEqual}");

        // Виведення довжини вектора v1
        Console.WriteLine($"Довжина вектора v1: {v1.Length()}");
    }
}

