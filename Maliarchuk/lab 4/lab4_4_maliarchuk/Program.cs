using System;

class Figure
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
}

class Rectangle : Figure
{
    private int _x1, _y1, _x2, _y2;

    public Rectangle(string name, int x1, int y1, int x2, int y2)
        : base(name) 
    {
        _x1 = x1;
        _y1 = y1;
        _x2 = x2;
        _y2 = y2;
    }

    public Rectangle() : this("Прямокутник", 0, 0, 1, 1) 
    {
    }

    public override void Display()
    {
        base.Display(); 
        Console.WriteLine($"Координати: ({_x1}, {_y1}), ({_x2}, {_y2})");
    }

    public double Area()
    {
        return Math.Abs((_x2 - _x1) * (_y2 - _y1));
    }
}

class RectangleColor : Rectangle
{
    private string _color;

    public RectangleColor(string name, int x1, int y1, int x2, int y2, string color)
        : base(name, x1, y1, x2, y2) 
    {
        _color = color;
    }

    public RectangleColor() : this("Прямокутник з кольором", 0, 0, 1, 1, "Безбарвний") 
    {
    }

    public override void Display()
    {
        base.Display(); 
        Console.WriteLine($"Колір: {_color}");
    }

    public new double Area()
    {
        double area = base.Area(); 
        Console.WriteLine($"Площа: {area}");
        return area;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure figure;

        figure = new Rectangle("Прямокутник", 2, 3, 5, 7);
        Console.WriteLine("Дані про прямокутник:");
        figure.Display();
        ((Rectangle)figure).Area(); 

        figure = new RectangleColor("Прямокутник з кольором", 1, 1, 4, 5, "Червоний");
        Console.WriteLine("\nДані про прямокутник з кольором:");
        figure.Display();
        ((RectangleColor)figure).Area(); 
    }
}
