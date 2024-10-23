using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("\nChoose Task:");
                Console.WriteLine("1. Count occurrences of the maximum element in an array and find its first occurrence");
                Console.WriteLine("2. Replace all maximum elements in a matrix with zeros");
                Console.WriteLine("3. Count pairs of positive and zero numbers in a sequence");
                Console.WriteLine("4. Replace matrix elements based on the average value");
                Console.WriteLine("5. Sum the row with the maximum element in a matrix");
                Console.WriteLine("6. Sum the elements of a one-dimensional array");
                Console.WriteLine("7. Exit the program");
                Console.Write("Your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        MaxOccurrencesInArray();
                        break;
                    case 2:
                        ReplaceMaxInMatrix();
                        break;
                    case 3:
                        CountPositiveAndZeroPairs();
                        break;
                    case 4:
                        ReplaceMatrixBasedOnAverage();
                        break;
                    case 5:
                        SumRowWithMaxElement();
                        break;
                    case 6:
                        SumArrayElements();
                        break;
                    case 7:
                        continueRunning = false;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Task 1
        static void MaxOccurrencesInArray()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            int max = A.Max();
            int countMax = 0;
            int firstIndex = -1;

            int index = 0;
            foreach (int element in A)
            {
                if (element == max)
                {
                    countMax++;
                    if (firstIndex == -1)
                    {
                        firstIndex = index + 1;
                    }
                }
                index++;
            }

            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Number of occurrences: {countMax}");
            Console.WriteLine($"First occurrence position: {firstIndex}");
        }


        // Task 2
        static void ReplaceMaxInMatrix()
        {
            Console.WriteLine("Enter the size of the square matrix:");
            int n = int.Parse(Console.ReadLine());
            double[,] matrix = new double[n, n];

            Console.WriteLine("Enter the matrix elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double max = matrix.Cast<double>().Max();

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix, n);

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

            Console.WriteLine("Matrix after replacing max elements with zero:");
            PrintMatrix(matrix, n);
        }

        // Task 3
        static void CountPositiveAndZeroPairs()
        {
            Console.WriteLine("Enter the size of the sequence:");
            int n = int.Parse(Console.ReadLine());
            double[] sequence = new double[n];

            Console.WriteLine("Enter the sequence elements:");
            for (int i = 0; i < n; i++)
            {
                sequence[i] = double.Parse(Console.ReadLine());
            }

            int positivePairs = 0;
            int zeroPairs = 0;

            for (int i = 1; i < n; i++)
            {
                if (sequence[i] > 0 && sequence[i - 1] > 0)
                {
                    positivePairs++;
                }
                if (sequence[i] == 0 && sequence[i - 1] == 0)
                {
                    zeroPairs++;
                }
            }

            Console.WriteLine($"Number of positive pairs: {positivePairs}");
            Console.WriteLine($"Number of zero pairs: {zeroPairs}");
        }


        // Task 4
        static void ReplaceMatrixBasedOnAverage()
        {
            Console.WriteLine("Enter the number of rows in the matrix:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns in the matrix:");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            Console.WriteLine("Enter the matrix elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix, n, m);

            int sum = 0;
            int totalElements = n * m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j];
                }
            }
            double avg = (double)sum / totalElements;

            Console.WriteLine($"Average value: {avg}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < avg)
                    {
                        matrix[i, j] = -1;
                    }
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            Console.WriteLine("Modified matrix:");
            PrintMatrix(matrix, n, m);
        }

        // Task 5
        static void SumRowWithMaxElement()
        {
            int[,] matrix = new int[6, 9];
            Console.WriteLine("Enter the matrix elements (6x9):");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int maxElement = matrix.Cast<int>().Max();
            int rowIndex = 0;

            for (int i = 0; i < 6; i++)
            {
                if (matrix[i, 0] <= maxElement && matrix[i, 8] >= maxElement)
                {
                    rowIndex = i;
                    break;
                }
            }

            int rowSum = 0;
            for (int j = 0; j < 9; j++)
            {
                rowSum += matrix[rowIndex, j];
            }

            Console.WriteLine($"Sum of elements in the row with the maximum element: {rowSum}");
        }

        // Task 6
        static void SumArrayElements()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;

            foreach (double element in array)
            {
                sum += element;
            }

            Console.WriteLine($"Sum of the elements: {sum}");
        }


        // Utility function to print a matrix (overloaded)
        static void PrintMatrix(double[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(int[,] matrix, int rows, int cols)
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
}