using System;

class Program
{
    static void Main()
    {
        int n = 6; 
        int m = 9; 

        int[,] matrix = new int[n, m];
        Console.WriteLine("Введіть елементи матриці 6 x 9:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Елемент [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int maxElement = matrix[0, 0];
        int rowWithMax = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    rowWithMax = i;
                }
            }
        }

        int sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum += matrix[rowWithMax, j];
        }
    
        Console.WriteLine("\nОригінальна матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nНайбільший елемент матриці: {maxElement}");
        Console.WriteLine($"Він знаходиться в рядку {rowWithMax + 1} (нумерація з 1)");
        Console.WriteLine($"Сума елементів цього рядка: {sum}");
    }

    
}
