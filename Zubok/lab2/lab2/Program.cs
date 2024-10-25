using System;

class Program
{
    static void Main()
    {
        // Завдання 1
        Console.WriteLine("Завдання 1");
        int[] A = { 1, 5, 3, 9, 9, 2, 9, 4 };
        int maxElement = FindMaxElement(A, out int maxCount, out int firstIndex);
        Console.WriteLine("Заданий масив:");
        PrintArray(A);
        Console.WriteLine($"Максимальний елемент: {maxElement}, кількість повторень: {maxCount}, перший індекс: {firstIndex}");
        

        // Завдання 2
        Console.WriteLine("\nЗавдання 2");
        double[,] matrix = {
            { 1.2, 5.3, 9.1 },
            { 7.2, 9.1, 3.5 },
            { 2.2, 6.6, 9.1 }
        };
        double maxMatrixElement = FindMaxInMatrix(matrix);
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);
        ModifyMatrix(matrix, maxMatrixElement);
        Console.WriteLine("Модифікована матриця:");
        PrintMatrix(matrix);

        // Завдання 3
        Console.WriteLine("\nЗавдання 3");
        double[] sequence = { 1.1, 0, 0, 3.5, -1, 0, 1.2, 2.1 };
        CountPairs(sequence, out int positivePairs, out int zeroPairs);
        Console.WriteLine("Заданий масив:");
        PrintArray(sequence);
        Console.WriteLine($"Сусідство двох додатних чисел: {positivePairs}, сусідство нульових елементів: {zeroPairs}");
        

        // Завдання 4
        Console.WriteLine("\nЗавдання 4");
        int[,] rectMatrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(rectMatrix);
        ModifyRectangleMatrix(rectMatrix);
        Console.WriteLine("Модифікована матриця:");
        PrintMatrix(rectMatrix);

        // Завдання 5
        Console.WriteLine("\nЗавдання 5");
        int[,] matrix6x9 = {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 11, 12, 13, 14, 15, 16, 17, 18, 19 },
            { 21, 22, 23, 24, 25, 26, 27, 28, 29 },
            { 31, 32, 33, 34, 35, 36, 37, 38, 39 },
            { 41, 42, 43, 44, 45, 46, 47, 48, 49 },
            { 51, 52, 53, 54, 55, 56, 57, 58, 59 }
        };
        Console.WriteLine("Задана матриця:");
        PrintMatrix(matrix6x9);
        int maxElement5 = FindMaxInMatrix(matrix6x9);
        int rowWithMax = FindRowWithMaxElement(matrix6x9, maxElement5);
        int rowSum = CalculateRowSum(matrix6x9, rowWithMax);
        Console.WriteLine($"Сума елементів рядка з найбільшим елементом ({maxElement5}): {rowSum}");

        // Завдання 6
        Console.WriteLine("\nЗавдання 6");
        double[] B = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        Console.WriteLine("Заданий масив:");
        PrintArray(B);
        double sum = CalculateArraySum(B);
        Console.WriteLine($"Сума елементів масиву: {sum}");
    }

    static int FindMaxElement(int[] array, out int count, out int firstIndex)
    {
        int max = array[0];
        count = 0;
        firstIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                count = 1;
                firstIndex = i;
            }
            else if (array[i] == max)
            {
                count++;
            }
        }
        return max;
    }

    static double FindMaxInMatrix(double[,] matrix)
    {
        double max = matrix[0, 0];
        foreach (var item in matrix)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }

    static void ModifyMatrix(double[,] matrix, double maxElement)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == maxElement)
                {
                    matrix[i, j] = 0;
                }
            }
        }
    }

    static void CountPairs(double[] sequence, out int positivePairs, out int zeroPairs)
    {
        positivePairs = 0;
        zeroPairs = 0;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > 0 && sequence[i + 1] > 0)
                positivePairs++;
            if (sequence[i] == 0 && sequence[i + 1] == 0)
                zeroPairs++;
        }
    }

    static void ModifyRectangleMatrix(int[,] matrix)
    {
        double average = 0;
        int totalElements = matrix.Length;

        foreach (var item in matrix)
        {
            average += item;
        }
        average /= totalElements;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = matrix[i, j] < average ? -1 : 1;
            }
        }
    }

    static int FindMaxInMatrix(int[,] matrix)
    {
        int max = matrix[0, 0];
        foreach (var item in matrix)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }

    static int FindRowWithMaxElement(int[,] matrix, int maxElement)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == maxElement)
                {
                    return i; // Повертає рядок з максимальним елементом
                }
            }
        }
        return -1; // Якщо не знайдено
    }

    static int CalculateRowSum(int[,] matrix, int row)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[row, j];
        }
        return sum;
    }

    static double CalculateArraySum(double[] array)
    {
        double sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum;
    }

    static void PrintMatrix<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],6} ");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray<T>(T[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}
