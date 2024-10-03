using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів масиву n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] array = new double[n];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент [{i + 1}]: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }

        Console.WriteLine($"\nСума елементів масиву: {sum:F2}");
    }
}
