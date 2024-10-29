using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберіть задачу (1-6):");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1:
                // Задача 1
                Console.Write("Введіть кількість елементів масиву: ");
                int n = int.Parse(Console.ReadLine());
                int[] A = new int[n];

                Console.WriteLine("Введіть елементи масиву:");
                for (int i = 0; i < n; i++)
                {
                    A[i] = int.Parse(Console.ReadLine());
                }

                int max = A[0];
                int count = 1;
                int firstIndex = 0;

                for (int i = 1; i < n; i++)
                {
                    if (A[i] > max)
                    {
                        max = A[i];
                        count = 1;
                        firstIndex = i;
                    }
                    else if (A[i] == max)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Максимальний елемент: {max}, Кількість: {count}, Перший індекс: {firstIndex + 1}");
                break;

            case 2:
                // Задача 2
                Console.Write("Введіть порядок матриці (n): ");
                int m = int.Parse(Console.ReadLine());
                double[,] matrix = new double[m, m];

                Console.WriteLine("Введіть елементи матриці:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                double maxElement = matrix[0, 0];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i, j] > maxElement)
                        {
                            maxElement = matrix[i, j];
                        }
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i, j] == maxElement)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }

                Console.WriteLine("Задана матриця:");
                PrintMatrix(matrix);
                break;

            case 3:
                // Задача 3
                Console.Write("Введіть кількість елементів: ");
                n = int.Parse(Console.ReadLine());
                double[] sequence = new double[n];

                Console.WriteLine("Введіть елементи послідовності:");
                for (int i = 0; i < n; i++)
                {
                    sequence[i] = double.Parse(Console.ReadLine());
                }

                int positiveCount = 0;
                int zeroCount = 0;

                for (int i = 1; i < n; i++)
                {
                    if (sequence[i] > 0 && sequence[i - 1] > 0)
                    {
                        positiveCount++;
                    }
                    if (sequence[i] == 0 && sequence[i - 1] == 0)
                    {
                        zeroCount++;
                    }
                }

                Console.WriteLine($"Кількість сусідств двох додатних чисел: {positiveCount}");
                Console.WriteLine($"Кількість сусідств двох нульових елементів: {zeroCount}");
                break;

            case 4:
                // Задача 4
                Console.Write("Введіть кількість рядків матриці (n): ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Введіть кількість стовпців матриці (m): ");
                int columns = int.Parse(Console.ReadLine());
                int[,] intMatrix = new int[rows, columns];
                double average = 0;

                Console.WriteLine("Введіть елементи матриці:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        intMatrix[i, j] = int.Parse(Console.ReadLine());
                        average += intMatrix[i, j];
                    }
                }

                average /= (rows * columns);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (intMatrix[i, j] < average)
                        {
                            intMatrix[i, j] = -1;
                        }
                        else
                        {
                            intMatrix[i, j] = 1;
                        }
                    }
                }

                Console.WriteLine("Модифікована матриця:");
                PrintMatrix(intMatrix);
                break;

            case 5:
                // Задача 5
                int[,] matrix6x9 = new int[6, 9];

                Console.WriteLine("Введіть елементи матриці 6x9:");
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        matrix6x9[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                int maxElementIndexRow = 0;
                int maxElementRow = 0;

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (matrix6x9[i, j] > maxElementRow)
                        {
                            maxElementRow = matrix6x9[i, j];
                            maxElementIndexRow = i;
                        }
                    }
                }

                int sumRow = 0;
                for (int j = 0; j < 9; j++)
                {
                    sumRow += matrix6x9[maxElementIndexRow, j];
                }

                Console.WriteLine($"Сума елементів рядка з найбільшим елементом: {sumRow}");
                break;

            case 6:
                // Задача 6
                Console.Write("Введіть кількість елементів масиву: ");
                n = int.Parse(Console.ReadLine());
                double[] realArray = new double[n];
                double sum = 0;

                Console.WriteLine("Введіть елементи масиву:");
                for (int i = 0; i < n; i++)
                {
                    realArray[i] = double.Parse(Console.ReadLine());
                    sum += realArray[i];
                }

                Console.WriteLine($"Сума елементів масиву: {sum}");
                break;

            default:
                Console.WriteLine("Невірний вибір задачі.");
                break;
        }
    }

    static void PrintMatrix(double[,] matrix)
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

    static void PrintMatrix(int[,] matrix)
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
