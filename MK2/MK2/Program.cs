using System;

class Square
{
    public double X { get; set; }
    public double Y { get; set; }
    public double SideLength { get; set; }

    public Square(double x, double y, double sideLength)
    {
        X = x;
        Y = y;
        SideLength = sideLength;
    }

    public virtual double CalculateArea()
    {
        return SideLength * SideLength;
    }

    public override string ToString()
    {
        return $"Square: точка ({X}, {Y}), сторона = {SideLength}, площа = {CalculateArea()}";
    }
}

class Cub : Square
{
    public Cub(double x, double y, double sideLength)
        : base(x, y, sideLength)
    {
    }

    public double CalculateFaceArea()
    {
        return CalculateArea();
    }

    public double CalculateTotalSurfaceArea()
    {
        return 6 * CalculateArea(); 
    }

    public override string ToString()
    {
        return $"Cub: точка ({X}, {Y}), сторона = {SideLength}, площа однієї грані = {CalculateFaceArea()}, загальна площа поверхні = {CalculateTotalSurfaceArea()}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть дані для квадрата:");
        Square square = CreateSquare();
        Console.WriteLine(square);

        Console.WriteLine("\nВведіть дані для куба:");
        Cub cub = CreateCub();
        Console.WriteLine(cub);
    }

    private static Square CreateSquare()
    {
        double x = ReadDouble("Введіть координату X: ");
        double y = ReadDouble("Введіть координату Y: ");
        double sideLength = ReadPositiveDouble("Введіть довжину сторони: ");
        return new Square(x, y, sideLength);
    }

    private static Cub CreateCub()
    {
        double x = ReadDouble("Введіть координату X: ");
        double y = ReadDouble("Введіть координату Y: ");
        double sideLength = ReadPositiveDouble("Введіть довжину сторони: ");
        return new Cub(x, y, sideLength);
    }

    private static double ReadDouble(string prompt)
    {
        double result;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out result))
                return result;

            Console.WriteLine("Некоректне значення. Спробуйте ще раз.");
        }
    }

    private static double ReadPositiveDouble(string prompt)
    {
        double result;
        while (true)
        {
            result = ReadDouble(prompt);
            if (result > 0)
                return result;

            Console.WriteLine("Число має бути додатним. Спробуйте ще раз.");
        }
    }
}
