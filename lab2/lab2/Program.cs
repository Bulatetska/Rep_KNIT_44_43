using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть задачу (1-6): ");
        int task = Convert.ToInt32(Console.ReadLine());

        switch (task)
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
            default:
                Console.WriteLine("Неправильний вибір.");
                break;
        }
    }

    static void Task1()
    {
        Console.Write("Введіть розмір масиву n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] A = new int[n];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = A[0];
        int maxCount = 1;
        int maxIndex = 0;

        for (int i = 1; i < n; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
                maxCount = 1;
                maxIndex = i;
            }
            else if (A[i] == max)
            {
                maxCount++;
            }
        }

        Console.WriteLine($"Максимальний елемент: {max}");
        Console.WriteLine($"Кількість його появ: {maxCount}");
        Console.WriteLine($"Порядковий номер першого найбільшого елементу: {maxIndex + 1}");
    }

    static void Task2()
    {
        Console.Write("Введіть порядок матриці n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] matrix = new double[n, n];

        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        double max = matrix[0, 0];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == max)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        Console.WriteLine("Задана матриця:");
        PrintMatrix(matrix, n);
    }

    static void PrintMatrix(double[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Task3()
    {
        Console.Write("Введіть розмір послідовності n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] a = new double[n];

        Console.WriteLine("Введіть елементи послідовності:");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToDouble(Console.ReadLine());
        }

        int positivePairs = 0;
        int zeroPairs = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (a[i] > 0 && a[i + 1] > 0)
            {
                positivePairs++;
            }
            if (a[i] == 0 && a[i + 1] == 0)
            {
                zeroPairs++;
            }
        }

        Console.WriteLine($"Кількість сусідств двох додатних чисел: {positivePairs}");
        Console.WriteLine($"Кількість сусідств двох нульових елементів: {zeroPairs}");
    }

    static void Task4()
    {
        Console.Write("Введіть кількість рядків n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть кількість стовпців m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, m];
        double sum = 0;

        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                sum += matrix[i, j];
            }
        }

        double average = sum / (n * m);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < average)
                {
                    matrix[i, j] = -1;
                }
                else
                {
                    matrix[i, j] = 1;
                }
            }
        }

        Console.WriteLine("Модифікована матриця:");
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

    static void Task5()
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
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int maxValue = matrix[0, 0];
        int maxRowIndex = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    maxRowIndex = i;
                }
            }
        }

        int sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum += matrix[maxRowIndex, j];
        }

        Console.WriteLine($"Сума елементів рядка з найбільшим елементом: {sum}");
    }

    static void Task6()
    {
        Console.Write("Введіть розмір масиву n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] A = new double[n];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            A[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        foreach (double element in A)
        {
            sum += element;
        }

        Console.WriteLine($"Сума елементів масиву: {sum}");
    }
}
