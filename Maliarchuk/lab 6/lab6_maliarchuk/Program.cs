using System;

abstract class Figure
{
    private string _name;

    public Figure(string name)
    {
        _name = name;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public abstract double Area2 { get; }

    public abstract double Area();

    public virtual void Print()
    {
        Console.WriteLine($"Фігура: {_name}");
    }
}

class Triangle : Figure
{
    private double _a, _b, _c;

    public Triangle(string name, double a, double b, double c)
        : base(name)
    {
        if (a + b > c && a + c > b && b + c > a)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        else
        {
            Console.WriteLine("Некоректні сторони трикутника. Використовуються значення за замовчуванням: a = b = c = 1.");
            _a = _b = _c = 1;
        }
    }

    public override double Area2
    {
        get
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }

    public override double Area()
    {
        return Area2;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Сторони: a = {_a}, b = {_b}, c = {_c}");
    }
}

class TriangleColor : Triangle
{
    private string _color;

    public TriangleColor(string name, double a, double b, double c, string color)
        : base(name, a, b, c)
    {
        _color = color;
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public override double Area2
    {
        get
        {
            Console.WriteLine("Виклик властивості Area2 у TriangleColor.");
            return base.Area2;
        }
    }

    public override double Area()
    {
        Console.WriteLine("Виклик методу Area у TriangleColor.");
        return base.Area();
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Колір: {_color}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure figure;

        Triangle triangle = new Triangle("Трикутник", 3, 4, 5);
        figure = triangle;
        Console.WriteLine("\nІнформація про трикутник:");
        figure.Print();
        Console.WriteLine($"Площа: {figure.Area2}");

        TriangleColor coloredTriangle = new TriangleColor("Кольоровий трикутник", 6, 8, 10, "Червоний");
        figure = coloredTriangle;
        Console.WriteLine("\nІнформація про кольоровий трикутник:");
        figure.Print();
        Console.WriteLine($"Площа: {figure.Area2}");
    }
}
