using System;

namespace Geometry
{
    // Абстрактний клас Figure
    public abstract class Figure
    {
        // 1. Приховане поле класу
        private string name; // Назва фігури

        // 2. Конструктор класу
        public Figure(string name)
        {
            this.name = name; // Ініціалізація поля name
        }

        // 4. Абстрактна властивість, яка повертає площу фігури
        public abstract double Area2 { get; }

        // 5. Абстрактний метод, який повертає площу фігури
        public abstract double Area();

        // Метод для виведення інформації про фігуру
        public virtual void Print()
        {
            Console.WriteLine($"Фігура: {name}");
        }
    }

    // Клас Triangle, що реалізує трикутник
    public class Triangle : Figure
    {
        // 1. Внутрішні поля класу
        private double a, b, c; // Сторони трикутника

        // 2. Конструктор класу
        public Triangle(string name, double a, double b, double c) : base(name)
        {
            // Перевірка на коректність значень a, b, c
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                Console.WriteLine("Некоректні значення a, b, c. Встановлено за замовчуванням: a=1, b=1, c=1.");
                this.a = this.b = this.c = 1;
            }
        }

        // Реалізація властивості Area2 для повернення площі трикутника
        public override double Area2 => Area(); // Автоматична властивість, що використовує метод Area()

        // Реалізація методу Area для обчислення площі трикутника
        public override double Area()
        {
            double s = (a + b + c) / 2; // Півпериметр
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); // Формула Герона
        }

        // Перевизначений метод Print для виведення інформації про трикутник
        public override void Print()
        {
            base.Print(); // Виводимо назву фігури
            Console.WriteLine($"Сторони: a={a}, b={b}, c={c}, Площа: {Area2}");
        }
    }

    // Клас TriangleColor, що розширює можливості класу Triangle
    public class TriangleColor : Triangle
    {
        // 1. Приховане поле для кольору
        private string color;

        // 2. Конструктор класу
        public TriangleColor(string name, double a, double b, double c, string color) 
            : base(name, a, b, c) // Викликаємо конструктор базового класу Triangle
        {
            this.color = color; // Ініціалізація кольору
        }

        // Властивість для доступу до поля color
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Віртуальний метод Print для виведення інформації про трикутник з кольором
        public override void Print()
        {
            base.Print(); // Виводимо інформацію з базового класу
            Console.WriteLine($"Колір: {color}");
        }
    }

    // Головний клас для тестування
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створюємо об'єкт класу TriangleColor
            TriangleColor triangleColor = new TriangleColor("Мій Трикутник", 3, 4, 5, "Червоний");

            // Виводимо інформацію про трикутник
            triangleColor.Print();

            Console.ReadKey(); // Чекаємо натискання клавіші
        }
    }
}
