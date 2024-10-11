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
    // Якщо обидва об'єкти null або є посилання на один і той самий об'єкт
    if (ReferenceEquals(v1, v2))
        return true;

    // Якщо один з об'єктів є null
    if (v1 is null || v2 is null)
        return false;

    // Порівняння координат векторів
    return v1.X == v2.X && v1.Y == v2.Y;
}


    // Оператор нерівності (!=) для порівняння двох векторів
    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    // Оператор множення (*) для множення вектора на скаляр
    public static Vector operator *(Vector v, double scalar)
    {
        return new Vector(v.X * scalar, v.Y * scalar);
    }

    // Метод для виведення вектора на екран
    public void Print()
    {
        Console.WriteLine($"Vector: ({X}, {Y})");
    }

    // Метод для отримання довжини вектора
    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Створити два вектори v1 = (3, 4) та v2 = (1, -2)
        Vector v1 = new Vector(3, 4);
        Vector v2 = new Vector(1, -2);

        // Вивести початкові вектори
        Console.WriteLine("Initial vectors:");
        v1.Print();
        v2.Print();

        // Змінити знаки координат вектора v1
        Vector v1Negated = -v1;
        Console.WriteLine("\nNegated v1:");
        v1Negated.Print();

        // Додати вектори v1 і v2
        Vector sum = v1 + v2;
        Console.WriteLine("\nSum of v1 and v2:");
        sum.Print();

        // Помножити вектор v2 на скаляр 2
        Vector v2Scaled = v2 * 2;
        Console.WriteLine("\nVector v2 multiplied by scalar 2:");
        v2Scaled.Print();

        // Порівняти два вектори на рівність
        Console.WriteLine("\nComparison of v1 and v2:");
        if (v1 == v2)
        {
            Console.WriteLine("v1 is equal to v2");
        }
        else
        {
            Console.WriteLine("v1 is not equal to v2");
        }

        // Вивести довжину вектора v1
        Console.WriteLine($"\nLength of v1: {v1.Length()}");
    }
}
