using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2) / 2;

        Console.WriteLine($"Середнє арифметичне: {average}");
    }
}
