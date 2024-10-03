using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть кількість стовпців m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, m];
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        double sum = 0;
        int totalElements = n * m;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sum += matrix[i, j];
            }
        }

        double average = sum / totalElements;

        Console.WriteLine("\nОригінальна матриця:");
        PrintMatrix(matrix, n, m);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < average)
                {
                    matrix[i, j] = -1;
                }
                else if (matrix[i, j] > average)
                {
                    matrix[i, j] = 1;
                }
            }
        }

        Console.WriteLine("\nРезультуюча матриця після заміни:");
        PrintMatrix(matrix, n, m);
    }

    static void PrintMatrix(int[,] matrix, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
