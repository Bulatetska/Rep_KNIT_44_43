using System;

abstract class Figure
{
    private string name;

    public Figure(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public abstract double Area2 { get; }

    public abstract double Area();

    public virtual void Print()
    {
        Console.WriteLine("name = {0}", name);
    }
}

class Triangle : Figure
{
    private double a, b, c;

    public Triangle(string name, double a, double b, double c) : base(name)
    {
        if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
        {
            this.a = a; this.b = b; this.c = c;
        }
        else
        {
            Console.WriteLine("Incorrect values a, b, c. By default: a=1, b=1, c=1.");
            this.a = this.b = this.c = 1;
        }
    }

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

    public void GetABC(out double a, out double b, out double c)
    {
        a = this.a;
        b = this.b;
        c = this.c;
    }

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

    public override double Area()
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("Method Triangle.Area(): s = {0:f3}", s);
        return s;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("a = {0:f2}", a);
        Console.WriteLine("b = {0:f2}", b);
        Console.WriteLine("c = {0:f2}", c);
    }
}

class TriangleColor : Triangle
{
    private string color;

    public TriangleColor(string name, double a, double b, double c, string color) : base(name, a, b, c)
    {
        this.color = color;
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public override double Area2
    {
        get
        {
            return base.Area2;  // Викликає Area2 базового класу Triangle
        }
    }

    public override double Area()
    {
        return base.Area();  // Викликає Area базового класу Triangle
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Color = {0}", color);
    }
}

class Program
{
    static void Main()
    {
        // Створюємо екземпляр класу TriangleColor
        TriangleColor triangle = new TriangleColor("Colored Triangle", 3, 4, 5, "Red");

        // Викликаємо методи та властивості для демонстрації
        triangle.Print();
        Console.WriteLine("Area using Area2 property: {0:f3}", triangle.Area2);
        Console.WriteLine("Area using Area() method: {0:f3}", triangle.Area());
    }
}
