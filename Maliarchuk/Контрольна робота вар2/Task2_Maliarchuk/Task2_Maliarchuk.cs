using System;

class Square
{
    public int X { get; set; }
    public int Y { get; set; }
    public double Side { get; set; }

    public Square(int x, int y, double side)
    {
        X = x;
        Y = y;
        Side = side;
    }

    public void IncreaseSide(double increment)
    {
        if (increment > 0)
        {
            Side += increment;
        }
        else
        {
            Console.WriteLine("Збільшення повинно бути додатнім.");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Квадрат: Координати вершини ({X}, {Y}), Сторона = {Side}");
    }
}

class Cub : Square
{
    public Cub(int x, int y, double side) : base(x, y, side) { }

    public void DisplayCub()
    {
        Console.WriteLine($"Куб: Координати вершини ({X}, {Y}), Сторона = {Side}");
    }
}

class Program
{
    static void Main()
    {
        Square square = new Square(0, 0, 5);
        square.Display();

        square.IncreaseSide(3);
        square.Display();

        Cub cub = new Cub(1, 1, 4);
        cub.DisplayCub();

        cub.IncreaseSide(2);
        cub.DisplayCub();
    }
}
