using System;

#region Абстрактний клас Figure
abstract class Figure
{
    public string Name { get; set; }

    public Figure(string name)
    {
        Name = name;
    }

    public abstract double Area();

    public virtual void Print()
    {
        Console.WriteLine($"Figure: {Name}");
    }
}
#endregion

#region Клас Triangle
class Triangle : Figure
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    // Властивість для обчислення площі трикутника за формулою Герона
    public override double Area()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Sides: {SideA}, {SideB}, {SideC}");
        Console.WriteLine($"Area: {Area()}");
    }
}
#endregion

#region Клас TriangleColor
class TriangleColor : Triangle
{
    private string color;

    // Конструктор з 5 параметрами
    public TriangleColor(string name, double sideA, double sideB, double sideC, string color)
    : base(name, sideA, sideB, sideC)
    {
        this.color = color;
    }

    // Властивість Color для доступу до поля color
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Властивість Area2, яка викликає метод Area() базового класу
    public double Area2
    {
        get { return base.Area(); }
    }

    // Метод Area(), який повертає площу трикутника за його сторонами (звертається до базового класу)
    public new double Area()
    {
        return base.Area();
    }

    // Віртуальний метод Print() для виведення внутрішніх полів класу
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Color: {Color}");
    }
}
#endregion

class Program
{
    static void Main()
    {
        // Створення екземпляра класу TriangleColor
        TriangleColor triangle = new TriangleColor("Colored Triangle", 3, 4, 5, "Red");

        // Виведення інформації про трикутник
        triangle.Print();
        Console.WriteLine($"Area using Area2 property: {triangle.Area2}");
    }
}
