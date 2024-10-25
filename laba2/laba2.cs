using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Оберіть номер завдання (1-6) або введіть 0 для виходу:");
            int choice = int.Parse(Console.ReadLine());// перетворює зчитаний рядок на ціле число типу int.

            switch (choice)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void Task1()
    {
        Console.WriteLine("Завдання 1:");
        Console.WriteLine("Введіть кількість елементів масиву:");
        int n = int.Parse(Console.ReadLine());
        
        int[] A = new int[n];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        int max = A.Max();
        int countMax = A.Count(x => x == max);
        int firstMaxIndex = Array.IndexOf(A, max) + 1;

        Console.WriteLine($"Максимальний елемент зустрічається {countMax} разів.");
        Console.WriteLine($"Перший найбільший елемент знаходиться на позиції {firstMaxIndex}.");
    }

    static void Task2()
    {
        Console.WriteLine("Завдання 2:");
        Console.WriteLine("Введіть розмір квадратної матриці:");
        int n = int.Parse(Console.ReadLine());
        
        double[,] matrix = new double[n, n];
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double maxElement = matrix.Cast<double>().Max();
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

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

        Console.WriteLine("Модифікована матриця:");
        PrintMatrix(matrix);
    }

    static void Task3()
    {
        Console.WriteLine("Завдання 3:");
        Console.WriteLine("Введіть кількість елементів послідовності:");
        int n = int.Parse(Console.ReadLine());
        
        double[] sequence = new double[n];
        Console.WriteLine("Введіть елементи послідовності:");
        for (int i = 0; i < n; i++)
        {
            sequence[i] = double.Parse(Console.ReadLine());
        }

        int positivePairs = 0;
        int zeroPairs = 0;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > 0 && sequence[i + 1] > 0) positivePairs++;
            if (sequence[i] == 0 && sequence[i + 1] == 0) zeroPairs++;
        }

        Console.WriteLine($"Сусідств двох додатних чисел: {positivePairs}");
        Console.WriteLine($"Сусідств двох нульових елементів: {zeroPairs}");
    }

    static void Task4()
    {
        Console.WriteLine("Завдання 4:");
        Console.WriteLine("Введіть кількість рядків:");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введіть кількість стовпців:");
        int m = int.Parse(Console.ReadLine());
        
        int[,] matrix = new int[n, m];
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);
        double avg = matrix.Cast<int>().Average();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = matrix[i, j] < avg ? -1 : 1;
            }
        }

        Console.WriteLine("Модифікована матриця:");
        PrintMatrix(matrix);
    }

    static void Task5()
    {
        Console.WriteLine("Завдання 5:");
        int[,] matrix = new int[6, 9];
        Console.WriteLine("Введіть елементи матриці 6x9:");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

        int maxElement = matrix.Cast<int>().Max();
        int rowWithMax = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == maxElement)
                {
                    rowWithMax = i;
                    break;
                }
            }
        }

        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[rowWithMax, j];
        }

        Console.WriteLine($"Сума елементів рядка з найбільшим елементом: {sum}");
    }

    static void Task6()
    {
        Console.WriteLine("Завдання 6:");
        Console.WriteLine("Введіть кількість елементів масиву:");
        int n = int.Parse(Console.ReadLine());
        
        double[] A = new double[n];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            A[i] = double.Parse(Console.ReadLine());
        }

        double sum = A.Sum();

        Console.WriteLine($"Сума елементів масиву: {sum}");
    }

    static void PrintMatrix(double[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void PrintMatrix(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
