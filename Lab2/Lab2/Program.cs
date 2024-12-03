using System;
using System.Linq;

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            // Виведення меню
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Find max element occurrences and its first position in array");
            Console.WriteLine("2. Replace max elements in square matrix with zeros");
            Console.WriteLine("3. Count neighbor positive and zero elements in sequence");
            Console.WriteLine("4. Replace matrix elements based on average value");
            Console.WriteLine("5. Find sum of row containing max element in matrix");
            Console.WriteLine("6. Find sum of elements in array");
            Console.WriteLine("0. Exit");

            // Вибір користувача
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    MaxElementOccurrences();
                    break;
                case "2":
                    ReplaceMaxElementsInMatrix();
                    break;
                case "3":
                    CountNeighbors();
                    break;
                case "4":
                    ReplaceMatrixElementsByAverage();
                    break;
                case "5":
                    SumOfRowWithMaxElement();
                    break;
                case "6":
                    SumOfArrayElements();
                    break;
                case "0":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    // Завдання 1: Максимальний елемент в масиві
    static void MaxElementOccurrences()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        int maxElement = A.Max();
        int countMax = A.Count(x => x == maxElement);
        int firstMaxIndex = Array.IndexOf(A, maxElement) + 1; // Позиція з 1

        Console.WriteLine($"Max element: {maxElement}, occurs {countMax} times, first position: {firstMaxIndex}");
    }

    // Завдання 2: Заміна максимальних елементів на нулі
    static void ReplaceMaxElementsInMatrix()
    {
        Console.Write("Enter the size of the square matrix (n): ");
        int n = int.Parse(Console.ReadLine());
        double[,] matrix = new double[n, n];

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double maxElement = matrix.Cast<double>().Max();

        Console.WriteLine("Original matrix:");
        PrintMatrix(matrix, n, n);

        // Замінюємо максимальні елементи на нулі
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == maxElement)
                    matrix[i, j] = 0;
            }
        }

        Console.WriteLine("Matrix after replacing max elements with zeros:");
        PrintMatrix(matrix, n, n);
    }

    // Завдання 3: Підрахунок сусідніх додатніх та нульових елементів
    static void CountNeighbors()
    {
        Console.Write("Enter the number of elements in the sequence: ");
        int n = int.Parse(Console.ReadLine());
        double[] sequence = new double[n];

        Console.WriteLine("Enter sequence elements:");
        for (int i = 0; i < n; i++)
        {
            sequence[i] = double.Parse(Console.ReadLine());
        }

        int positivePairs = 0;
        int zeroPairs = 0;

        for (int i = 1; i < n; i++)
        {
            if (sequence[i] > 0 && sequence[i - 1] > 0)
                positivePairs++;

            if (sequence[i] == 0 && sequence[i - 1] == 0)
                zeroPairs++;
        }

        Console.WriteLine($"Number of neighboring positive pairs: {positivePairs}");
        Console.WriteLine($"Number of neighboring zero pairs: {zeroPairs}");
    }

    // Завдання 4: Замінюємо елементи матриці на основі середнього арифметичного
    static void ReplaceMatrixElementsByAverage()
    {
        Console.Write("Enter the number of rows (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns (m): ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        double average = matrix.Cast<int>().Average();

        Console.WriteLine($"Average value: {average}");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < average)
                    matrix[i, j] = -1;
                else if (matrix[i, j] > average)
                    matrix[i, j] = 1;
            }
        }

        Console.WriteLine("Matrix after replacement:");
        PrintMatrix(matrix, n, m);
    }

    // Завдання 5: Знайти суму елементів рядка, що містить найбільший елемент
    static void SumOfRowWithMaxElement()
    {
        // Задаємо матрицю в коді
        int[,] matrix = {
            { 5, 2, 8, 7, 4, 1, 9, 3, 6 },
            { 1, 3, 5, 7, 2, 8, 6, 4, 0 },
            { 4, 8, 1, 0, 3, 2, 5, 9, 6 },
            { 0, 6, 3, 2, 1, 25, 4, 8, 7 },
            { 2, 5, 4, 3, 8, 1, 0, 6, 7 },
            { 9, 7, 6, 5, 4, 3, 2, 1, 0 }
        };

        int maxElement = matrix.Cast<int>().Max();
        int rowIndex = -1;

        // Пошук рядка з максимальним елементом
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (matrix[i, j] == maxElement)
                {
                    rowIndex = i;
                    break;
                }
            }
            if (rowIndex != -1) break;
        }

        // Підрахунок суми елементів в рядку
        int rowSum = 0;
        for (int j = 0; j < 9; j++)
        {
            rowSum += matrix[rowIndex, j];
        }

        Console.WriteLine($"Sum of elements in the row containing max element ({maxElement}): {rowSum}");
    }

    // Завдання 6: Знайти суму елементів масиву
    static void SumOfArrayElements()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        double sum = array.Sum();
        Console.WriteLine($"Sum of array elements: {sum}");
    }

    // Допоміжна функція для виведення матриці
    static void PrintMatrix<T>(T[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
