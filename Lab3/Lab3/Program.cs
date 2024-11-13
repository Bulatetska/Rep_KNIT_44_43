using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Завдання 1: Максимальний елемент в одновимірному масиві
        Console.WriteLine("Завдання 1: Максимальний елемент в одновимірному масиві");
        int[] array = { 3, 5, 7, 7, 2, 7, 4 };  
        int max = array.Max();
        int countMax = array.Count(x => x == max);
        Console.WriteLine("Масив: " + string.Join(", ", array));
        int firstIndexMax = Array.IndexOf(array, max) + 1;
        Console.WriteLine($"Максимальний елемент: {max}");
        Console.WriteLine($"Кількість повторень: {countMax}");
        Console.WriteLine($"Перший індекс максимального елемента: {firstIndexMax}");

        Console.WriteLine();

        // Завдання 2: Заміна максимальних елементів у квадратній матриці нулями
        Console.WriteLine("Завдання 2: Заміна максимальних елементів у квадратній матриці нулями");
        double[,] matrix = {
            { 1.1, 3.3, 3.3 },
            { 2.2, 3.3, 1.2 },
            { 1.3, 0.5, 3.3 }
        };
        double maxMatrix = matrix.Cast<double>().Max();
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == maxMatrix)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        Console.WriteLine("Модифікована матриця:");
        PrintMatrix(matrix);

        Console.WriteLine();

        // Завдання 3: Кількість сусідств двох додатних чисел та двох нулів
        Console.WriteLine("Завдання 3: Кількість сусідств двох додатних чисел та двох нулів");
        double[] sequence = { 1.2, 0, 0, -1.1, 2.3, 2.2, 0, 0 };
        int positivePairs = 0, zeroPairs = 0;
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > 0 && sequence[i + 1] > 0)
                positivePairs++;
            if (sequence[i] == 0 && sequence[i + 1] == 0)
                zeroPairs++;
        }
        Console.WriteLine($"Кількість пар додатних чисел: {positivePairs}");
        Console.WriteLine($"Кількість пар нульових чисел: {zeroPairs}");

        Console.WriteLine();

        // Завдання 4: Заміна елементів матриці залежно від середнього значення
        Console.WriteLine("Завдання 4: Заміна елементів матриці залежно від середнього значення");
        int[,] rectMatrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        double avg = rectMatrix.Cast<int>().Average();
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(rectMatrix);

        for (int i = 0; i < rectMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < rectMatrix.GetLength(1); j++)
            {
                rectMatrix[i, j] = rectMatrix[i, j] < avg ? -1 : 1;
            }
        }
        Console.WriteLine("Модифікована матриця:");
        PrintMatrix(rectMatrix);

        Console.WriteLine();

        // Завдання 5: Сума елементів рядка з найбільшим елементом у матриці 6x9
        Console.WriteLine("Завдання 5: Сума елементів рядка з найбільшим елементом у матриці 6x9");
        int[,] matrix6x9 = {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 10, 11, 12, 13, 14, 15, 16, 17, 18 },
            { 19, 20, 21, 22, 23, 24, 25, 26, 27 },
            { 28, 29, 30, 31, 32, 33, 34, 35, 36 },
            { 37, 38, 39, 40, 41, 42, 43, 44, 45 },
            { 46, 47, 48, 49, 50, 51, 52, 53, 54 }
        };
        int maxElement = matrix6x9.Cast<int>().Max();
        int rowWithMax = -1;
        for (int i = 0; i < matrix6x9.GetLength(0); i++)
        {
            for (int j = 0; j < matrix6x9.GetLength(1); j++)
            {
                if (matrix6x9[i, j] == maxElement)
                {
                    rowWithMax = i;
                    break;
                }
            }
            if (rowWithMax != -1) break;
        }
        int rowSum = 0;
        for (int j = 0; j < matrix6x9.GetLength(1); j++)
        {
            rowSum += matrix6x9[rowWithMax, j];
        }
        Console.WriteLine($"Сума елементів рядка з найбільшим елементом: {rowSum}");

        Console.WriteLine();

        // Завдання 6: Сума елементів одновимірного масиву
        Console.WriteLine("Завдання 6: Сума елементів одновимірного масиву");
        double[] arrayDoubles = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        double sum = arrayDoubles.Sum();
        Console.WriteLine($"Сума елементів масиву: {sum}");
    }

    static void PrintMatrix<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
