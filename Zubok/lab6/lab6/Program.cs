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

        // Перевантаження бінарного оператора додавання (+) для додавання двох векторів
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
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

        // Перевантаження оператора множення (*) для множення вектора на скаляр
        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar);
        }

        // Метод для виведення координат вектора на екран
        public void Display()
        {
            Console.WriteLine($"Vector: ({X}, {Y})");
        }

        // Метод для обчислення довжини вектора
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        // Перевизначення Equals() та GetHashCode() для коректної роботи оператора рівності
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

            // Виведення початкових значень векторів
            Console.Write("Initial v1: ");
            v1.Display();
            Console.Write("Initial v2: ");
            v2.Display();

            // Змінити знаки координат вектора v1
            Vector negV1 = -v1;
            Console.Write("Negated v1: ");
            negV1.Display();

            // Додавання векторів v1 і v2
            Vector sum = v1 + v2;
            Console.Write("Sum of v1 and v2: ");
            sum.Display();

            // Множення вектора v2 на скаляр 2
            Vector scaledV2 = v2 * 2;
            Console.Write("v2 multiplied by 2: ");
            scaledV2.Display();

            // Порівняння векторів на рівність
            bool isEqual = v1 == v2;
            Console.WriteLine($"v1 == v2: {isEqual}");

            // Довжини векторів
            Console.WriteLine($"Length of v1: {v1.Length():F2}");
            Console.WriteLine($"Length of v2: {v2.Length():F2}");
        }
    }
}
