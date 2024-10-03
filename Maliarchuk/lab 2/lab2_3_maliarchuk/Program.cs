using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів послідовності n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] sequence = new double[n];
        Console.WriteLine("Введіть елементи послідовності:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент a[{i + 1}]: ");
            sequence[i] = Convert.ToDouble(Console.ReadLine());
        }

        int positivePairs = 0;
        int zeroPairs = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (sequence[i] > 0 && sequence[i + 1] > 0)
            {
                positivePairs++;
            }

            if (sequence[i] == 0 && sequence[i + 1] == 0)
            {
                zeroPairs++;
            }
        }

        Console.WriteLine($"\nКількість пар двох додатних чисел: {positivePairs}");
        Console.WriteLine($"Кількість пар двох нульових елементів: {zeroPairs}");
    }
}
