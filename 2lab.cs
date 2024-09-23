using System;

class Program
{
    static void Main()
    {
        // Завдання 1: Одновимірний масив, максимальний елемент
        Console.WriteLine("Завдання 1: Одновимірний масив, максимальний елемент");
        int[] A = { 1, 5, 3, 9, 9, 2, 9 };
        int max = A[0];
        int maxCount = 0;
        int firstMaxIndex = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
                maxCount = 1;
                firstMaxIndex = i + 1;
            }
            else if (A[i] == max)
            {
                maxCount++;
            }
        }
        Console.WriteLine($"Максимальний елемент: {max}, кількість разів: {maxCount}, перший індекс: {firstMaxIndex}\n");

        // Завдання 2: Квадратна дійсна матриця, заміна максимальних елементів на нулі
        Console.WriteLine("Завдання 2: Квадратна дійсна матриця, заміна максимальних елементів на нулі");
        double[,] matrix = {
{ 1.2, 3.4, 5.6 },
{ 7.8, 9.0, 2.3 },
{ 4.5, 6.7, 9.0 }
};
        int n = matrix.GetLength(0);
        double maxElement = matrix[0, 0];

        // Знаходимо максимальний елемент
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (matrix[i, j] > maxElement)
                    maxElement = matrix[i, j];

        // Виводимо початкову матрицю
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

        // Замінюємо максимальні елементи на нулі
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (matrix[i, j] == maxElement)
                    matrix[i, j] = 0;

        // Виводимо результуючу матрицю
        Console.WriteLine("Результуюча матриця:");
        PrintMatrix(matrix);
        Console.WriteLine();

        // Завдання 3: Кількість сусідств
        Console.WriteLine("Завдання 3: Кількість сусідств");
        double[] sequence = { 1.0, 2.0, 0.0, 0.0, 3.0, 4.0, -1.0, 2.0, 0.0, 0.0 };
        int positivePairs = 0;
        int zeroPairs = 0;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > 0 && sequence[i + 1] > 0)
                positivePairs++;
            if (sequence[i] == 0 && sequence[i + 1] == 0)
                zeroPairs++;
        }

        Console.WriteLine($"Кількість сусідств двох додатних чисел: {positivePairs}");
        Console.WriteLine($"Кількість сусідств двох нульових елементів: {zeroPairs}\n");
        // Завдання 4: Прямокутна матриця, заміна елементів
        Console.WriteLine("Завдання 4: Прямокутна матриця, заміна елементів");
        int[,] rectMatrix = {
{ 3, 5, 1 },
{ 4, 2, 8 },
{ 9, 6, 7 }
};
        int rows = rectMatrix.GetLength(0);
        int cols = rectMatrix.GetLength(1);
        double sum = 0;
        int totalElements = rows * cols;

        // Знаходимо суму елементів
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                sum += rectMatrix[i, j];

        // Знаходимо середнє арифметичне
        double average = sum / totalElements;

        // Заміна елементів
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                rectMatrix[i, j] = rectMatrix[i, j] < average ? -1 : 1;

        // Виводимо результуючу матрицю
        Console.WriteLine("Результуюча матриця:");
        PrintMatrix(rectMatrix);
        Console.WriteLine();

        // Завдання 5: Матриця 6х9, сума елементів рядка з найбільшим елементом
        Console.WriteLine("Завдання 5: Сума елементів рядка з найбільшим елементом");
        int[,] matrix6x9 = {
{ 1, 2, 3, 4, 5, 6, 7, 8, 9 },
{ 9, 8, 7, 6, 5, 4, 3, 2, 1 },
{ 2, 3, 4, 5, 6, 7, 8, 9, 0 },
{ 1, 2, 3, 9, 5, 6, 7, 8, 9 },
{ 4, 5, 6, 7, 8, 9, 0, 1, 2 },
{ 7, 8, 9, 0, 1, 2, 3, 4, 5 }
};
        int maxRow = 0;
        int maxVal = matrix6x9[0, 0];
        // Знаходимо рядок з найбільшим елементом
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 9; j++)
                if (matrix6x9[i, j] > maxVal)
                {
                    maxVal = matrix6x9[i, j];
                    maxRow = i;
                }

        // Обчислюємо суму елементів цього рядка
        int rowSum = 0;
        for (int j = 0; j < 9; j++)
            rowSum += matrix6x9[maxRow, j];

        Console.WriteLine($"Сума елементів рядка з найбільшим елементом: {rowSum}\n");

        // Завдання 6: Одновимірний масив, сума елементів
        Console.WriteLine("Завдання 6: Сума елементів одновимірного масиву");
        double[] array = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        double arraySum = 0;

        foreach (double num in array)
            arraySum += num;

        Console.WriteLine($"Сума елементів масиву: {arraySum}");
    }

    // Метод для виведення матриці
    static void PrintMatrix<T>(T[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
