using System;

namespace ConsoleApplication8
{
    // Абстрактний клас Figure - містить абстрактний метод Area() і абстрактну властивість Area2
    abstract class Figure
    {
        // 1. Приховане поле класу
        private string name; // Назва фігури

        // 2. Конструктор класу
        public Figure(string name)
        {
            this.name = name;
        }

        // 3. Властивість доступу до поля класу
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 4. Абстрактна властивість, яка повертає площу фігури
        public abstract double Area2 { get; }

        // 5. Абстрактний метод, який повертає площу фігури
        public abstract double Area();

        // 6. Віртуальний метод, який виводить значення полів класу
        public virtual void Print()
        {
            Console.WriteLine("name = {0}", name);
        }
    }

    // Клас, що реалізує трикутник
    class Triangle : Figure
    {
        // 1. Внутрішні поля класу
        protected double a, b, c;

        // 2. Конструктор класу
        public Triangle(string name, double a, double b, double c)
            : base(name)
        {
            if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
            {
                this.a = a; this.b = b; this.c = c;
            }
            else
            {
                Console.WriteLine("Incorrect values a, b, c. Using default values (a=1, b=1, c=1).");
                this.a = this.b = this.c = 1;
            }
        }

        // Встановлення значень полів a, b, c
        public void SetABC(double a, double b, double c)
        {
            if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
            {
                this.a = a; this.b = b; this.c = c;
            }
            else
            {
                this.a = this.b = this.c = 1;
            }
        }

        // Читання значень полів
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a; b = this.b; c = this.c;
        }

        // Перевизначення абстрактної властивості Area2 класу Figure
        public override double Area2
        {
            get
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Property Triangle.Area2: s = {0:f3}", s);
                return s;
            }
        }

        // Реалізація методу Area()
        public override double Area()
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Method Triangle.Area(): s = {0:f3}", s);
            return s;
        }

        // Віртуальний метод Print
        public override void Print()
        {
            base.Print();
            Console.WriteLine("a = {0:f2}", a);
            Console.WriteLine("b = {0:f2}", b);
            Console.WriteLine("c = {0:f2}", c);
        }
    }

    // Клас, що визначає трикутник з кольором
    class TriangleColor : Triangle
    {
        // Приховане поле color
        private int color;

        // Конструктор з 5 параметрами
        public TriangleColor(string name, double a, double b, double c, int color)
            : base(name, a, b, c)
        {
            this.color = (color >= 0 && color <= 255) ? color : 0;
        }

        // Властивість доступу до поля color
        public int Color
        {
            get { return color; }
            set
            {
                if (value >= 0 && value <= 255)
                    color = value;
                else
                    color = 0;
            }
        }

        // Властивість Area2 - викликає однойменну властивість базового класу
        public override double Area2
        {
            get
            {
                Console.WriteLine("Property TriangleColor.Area2:");
                return base.Area2;
            }
        }

        // Метод Area(), який повертає площу трикутника
        public override double Area()
        {
            Console.WriteLine("Method TriangleColor.Area():");
            return base.Area();
        }

        // Віртуальний метод Print() для виведення внутрішніх полів класу
        public override void Print()
        {
            base.Print();
            Console.WriteLine("color = {0}", color);
        }
    }

    class Program
    {
        static void Main()
        {
            // Створення об'єктів класу Triangle та TriangleColor
            Triangle triangle = new Triangle("Simple Triangle", 3, 4, 5);
            triangle.Print();
            Console.WriteLine("Triangle Area: {0:f3}", triangle.Area());

            TriangleColor coloredTriangle = new TriangleColor("Colored Triangle", 3, 4, 5, 128);
            coloredTriangle.Print();
            Console.WriteLine("Triangle Color Area: {0:f3}", coloredTriangle.Area());
        }
    }
}
