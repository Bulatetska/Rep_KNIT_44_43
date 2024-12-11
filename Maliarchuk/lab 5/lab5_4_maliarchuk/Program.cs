using System;

abstract class Figure
{
    private string _name;

    public Figure(string name)
    {
        _name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Фігура: {_name}");
    }

    public abstract double Area();
}

class Rectangle : Figure
{
    private double _x1, _y1, _x2, _y2;

    public Rectangle(string name, double x1, double y1, double x2, double y2)
        : base(name)
    {
        _x1 = x1;
        _y1 = y1;
        _x2 = x2;
        _y2 = y2;
    }

    public Rectangle() : this("Прямокутник", 0, 0, 1, 1) { }

    public override double Area()
    {
        return Math.Abs((_x2 - _x1) * (_y2 - _y1));
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Координати: ({_x1}, {_y1}), ({_x2}, {_y2})");
    }
}

class RectangleColor : Rectangle
{
    private string _color;

    public RectangleColor(string name, double x1, double y1, double x2, double y2, string color)
        : base(name, x1, y1, x2, y2)
    {
        _color = color;
    }

    public string Color { get => _color; set => _color = value; }

    public override double Area()
    {
        return base.Area();
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Колір: {_color}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure figure = new Rectangle("Прямокутник", 2, 3, 5, 7);
        figure.Display();
        Console.WriteLine($"Площа: {figure.Area()}");

        Figure coloredFigure = new RectangleColor("Кольоровий прямокутник", 0, 0, 4, 5, "Червоний");
        coloredFigure.Display();
        Console.WriteLine($"Площа: {coloredFigure.Area()}");
    }
}
