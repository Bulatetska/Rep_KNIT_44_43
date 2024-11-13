using System;

namespace VectorOperations
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Унарний мінус: зміна знаків координат
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        // Бінарний оператор додавання: додавання двох векторів
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Оператор рівності
        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }

        // Оператор нерівності
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        // Оператор множення: множення вектора на скаляр
        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(v.X * scalar, v.Y * scalar);
        }

        // Метод для виведення вектора
        public void Print()
        {
            Console.WriteLine($"Вектор ({X}, {Y})");
        }

        // Метод для обчислення довжини вектора
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        // Перевизначення методів Equals та GetHashCode для коректної роботи оператора рівності
        public override bool Equals(object obj)
        {
            if (obj is Vector other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення векторів
            Vector v1 = new Vector(3, 4);
            Vector v2 = new Vector(1, -2);

            Console.WriteLine("Початкові вектори:");
            v1.Print();
            v2.Print();

            // Зміна знаків координат вектора v1
            Vector negV1 = -v1;
            Console.WriteLine("\nЗміна знаків координат вектора v1:");
            negV1.Print();

            // Додавання векторів v1 і v2
            Vector sum = v1 + v2;
            Console.WriteLine("\nСума векторів v1 і v2:");
            sum.Print();

            // Множення вектора v2 на скаляр 2
            Vector scaledV2 = v2 * 2;
            Console.WriteLine("\nМноження вектора v2 на скаляр 2:");
            scaledV2.Print();

            // Порівняння векторів на рівність
            Console.WriteLine("\nПорівняння векторів v1 і v2 на рівність:");
            Console.WriteLine(v1 == v2 ? "Вектори рівні" : "Вектори не рівні");

            // Виведення довжини вектора v1
            Console.WriteLine($"\nДовжина вектора v1: {v1.Length()}");
        }
    }
}
