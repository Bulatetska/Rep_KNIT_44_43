using System;

namespace VectorOperations
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Конструктор для ініціалізації координат вектора
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Перевантаження унарного мінуса (-) для зміни знаків координат
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        // Перевантаження оператора додавання (+) для додавання двох векторів
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Перевантаження оператора множення (*) для множення вектора на скаляр
        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar);
        }

        public static Vector operator *(double scalar, Vector v)
        {
            return v * scalar;
        }

        // Перевантаження оператора рівності (==) для порівняння двох векторів
        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }

        // Перевантаження оператора нерівності (!=) для порівняння двох векторів
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        // Метод для обчислення довжини вектора
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        // Метод для виведення вектора на екран
        public void Print()
        {
            Console.WriteLine($"Vector({X}, {Y})");
        }

        // Перевизначення методів Equals та GetHashCode для коректної роботи операторів == та !=
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
            // Створення векторів v1 та v2
            Vector v1 = new Vector(3, 4);
            Vector v2 = new Vector(1, -2);

            // Виведення векторів на екран
            Console.WriteLine("Початкові вектори:");
            v1.Print();
            v2.Print();

            // Зміна знаків координат вектора v1
            Vector v1Negated = -v1;
            Console.WriteLine("\nЗміна знаків координат вектора v1:");
            v1Negated.Print();

            // Додавання векторів v1 та v2
            Vector v3 = v1 + v2;
            Console.WriteLine("\nСума векторів v1 та v2:");
            v3.Print();

            // Множення вектора v2 на скаляр 2
            Vector v2Scaled = v2 * 2;
            Console.WriteLine("\nВектор v2, помножений на скаляр 2:");
            v2Scaled.Print();

            // Порівняння двох векторів на рівність
            Console.WriteLine("\nПорівняння векторів v1 і v2:");
            Console.WriteLine(v1 == v2 ? "Вектори рівні" : "Вектори не рівні");

            // Довжина вектора v1
            Console.WriteLine($"\nДовжина вектора v1: {v1.Length():F2}");
        }
    }
}
