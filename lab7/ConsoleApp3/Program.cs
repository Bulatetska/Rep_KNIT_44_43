using System;

class Vector
{
    // Внутрішні поля для координат вектора
    private double x;
    private double y;

    // Конструктор для ініціалізації координат
    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Властивість для отримання координати x
    public double X => x;

    // Властивість для отримання координати y
    public double Y => y;

    // Перевантаження унарного мінуса (-)
    public static Vector operator -(Vector v)
    {
        return new Vector(-v.x, -v.y);
    }

    // Перевантаження бінарного оператора додавання (+)
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.x + v2.x, v1.y + v2.y);
    }

    // Перевантаження оператора рівності (==)
    public static bool operator ==(Vector v1, Vector v2)
    {
        if (ReferenceEquals(v1, v2)) return true;
        if (ReferenceEquals(v1, null) || ReferenceEquals(v2, null)) return false;
        return v1.x == v2.x && v1.y == v2.y;
    }

    // Перевантаження оператора нерівності (!=)
    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    // Перевантаження оператора множення (*)
    public static Vector operator *(Vector v, double scalar)
    {
        return new Vector(v.x * scalar, v.y * scalar);
    }

    // Метод для отримання довжини вектора
    public double Length()
    {
        return Math.Sqrt(x * x + y * y);
    }

    // Метод для виведення вектора на екран
    public override string ToString()
    {
        return $"({x}, {y})";
    }

    // Переопределение метода Equals
    public override bool Equals(object obj)
    {
        return this == (Vector)obj;
    }

    // Переопределение хеш-коду
    public override int GetHashCode()
    {
        return (x, y).GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створюємо два вектори
        Vector v1 = new Vector(3, 4);
        Vector v2 = new Vector(1, -2);

        // Змінюємо знаки координат вектора v1
        Vector v1Negated = -v1;
        Console.WriteLine($"Змінений вектор v1: {v1Negated}"); // (-3, -4)

        // Додаємо вектори v1 і v2
        Vector sum = v1 + v2;
        Console.WriteLine($"Сума векторів v1 і v2: {sum}"); // (4, 2)

        // Помножуємо вектор v2 на скаляр 2
        Vector v2Scaled = v2 * 2;
        Console.WriteLine($"Вектор v2, помножений на 2: {v2Scaled}"); // (2, -4)

        // Порівнюємо два вектори на рівність
        bool areEqual = v1 == v2;
        Console.WriteLine($"Вектори v1 і v2 рівні: {areEqual}"); // false

        // Виводимо довжини векторів
        Console.WriteLine($"Довжина вектора v1: {v1.Length()}"); // 5
        Console.WriteLine($"Довжина вектора v2: {v2.Length()}"); // 2.23606797749979
    }
}
