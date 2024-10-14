using System;

namespace Geometry
{
    // Абстрактний клас Figure
    abstract class Figure
    {
        private string name; // Назва фігури

        // Конструктор з 1 параметром
        public Figure(string name)
        {
            this.name = name;
        }

        // Властивість для доступу до поля name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Абстрактна властивість для площі
        public abstract double Area2 { get; }

        // Абстрактний метод для обчислення площі
        public abstract double Area();

        // Віртуальний метод Print для виведення назви фігури
        public virtual void Print()
        {
            Console.WriteLine($"Figure: {name}");
        }
    }

    // Клас Triangle, успадковує Figure
    class Triangle : Figure
    {
        private double a, b, c; // Сторони трикутника

        // Конструктор з 4 параметрами
        public Triangle(string name, double a, double b, double c)
            : base(name)
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                Console.WriteLine("Invalid triangle sides. Setting default values (1, 1, 1).");
                this.a = this.b = this.c = 1;
            }
        }

        // Властивість для площі трикутника (формула Герона)
        public override double Area2
        {
            get
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        // Метод для обчислення площі трикутника
        public override double Area()
        {
            return Area2;
        }

        // Перевизначений метод Print для виведення інформації про трикутник
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Sides: a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"Area: {Area()}");
        }
    }

    // Клас TriangleColor, успадковує Triangle
    class TriangleColor : Triangle
    {
        private string color; // Колір фону трикутника

        // Конструктор з 5 параметрами
        public TriangleColor(string name, double a, double b, double c, string color)
            : base(name, a, b, c)
        {
            this.color = color;
        }

        // Властивість для доступу до поля color
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Властивість Area2 (викликає Area2 базового класу)
        public override double Area2
        {
            get
            {
                Console.WriteLine("Calculating area in TriangleColor...");
                return base.Area2;
            }
        }

        // Метод Area (викликає Area базового класу)
        public override double Area()
        {
            Console.WriteLine("Using method Area in TriangleColor...");
            return base.Area();
        }

        // Віртуальний метод Print для виведення внутрішніх полів
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Color: {color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземплярів класів
            Figure triangle = new Triangle("Simple Triangle", 3, 4, 5);
            Figure coloredTriangle = new TriangleColor("Colored Triangle", 3, 4, 5, "Red");

            // Виклик методів Print і Area через базовий клас Figure
            triangle.Print();
            Console.WriteLine();

            coloredTriangle.Print();
            Console.WriteLine();

            // Виведення площі через властивість Area2
            Console.WriteLine($"Area of {triangle.Name}: {triangle.Area2}");
            Console.WriteLine($"Area of {coloredTriangle.Name}: {coloredTriangle.Area2}");
        }
    }
}
