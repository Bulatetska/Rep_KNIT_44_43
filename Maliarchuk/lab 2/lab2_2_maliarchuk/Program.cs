using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть порядок квадратної матриці n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] matrix = new double[n, n];
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("\nОригінальна матриця:");
        PrintMatrix(matrix);

        double maxElement = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == maxElement)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        Console.WriteLine("\nРезультуюча матриця після заміни максимальних елементів на 0:");
        PrintMatrix(matrix);
    }

    static void PrintMatrix(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
