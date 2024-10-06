
class Program
{
    static void Main(string[] args)
    {
        // Задання 1
        Task1();

        // Задання 2
        Task2();

        // Задання 3
        Task3();
    }

    static void Task1()
    {
        Console.WriteLine("Задання 1: Введіть кількість елементів масиву:");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];

        Console.WriteLine("Введіть елементи масиву (через пробіл):");
        string[] input = Console.ReadLine().Split(' ');

        // Перевірка, чи кількість введених чисел дорівнює n
        if (input.Length != n)
        {
            Console.WriteLine($"Помилка: очікується {n} елементів, але введено {input.Length}.");
            return;
        }

        // Заповнення масиву
        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(input[i]);
        }

        int maxElement = A[0];
        int maxCount = 1;
        int firstMaxIndex = 0;

        for (int i = 1; i < n; i++)
        {
            if (A[i] > maxElement)
            {
                maxElement = A[i];
                maxCount = 1;
                firstMaxIndex = i;
            }
            else if (A[i] == maxElement)
            {
                maxCount++;
            }
        }

        Console.WriteLine($"Максимальний елемент: {maxElement}, кількість: {maxCount}, порядковий номер: {firstMaxIndex + 1}");
    }

    static void Task2()
    {
        Console.WriteLine("Задання 2: Введіть кількість рядків та стовпців матриці (n x m):");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        double[,] matrix = new double[rows, cols];

        Console.WriteLine("Введіть елементи матриці (через пробіл):");
        for (int i = 0; i < rows; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            // Перевірка, чи кількість введених чисел дорівнює cols
            if (input.Length != cols)
            {
                Console.WriteLine($"Помилка: очікується {cols} елементів, але введено {input.Length}.");
                return;
            }

            // Заповнення рядка матриці
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = double.Parse(input[j]);
            }
        }

        // Виведення початкової матриці
        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

        // Заміна максимальних елементів на нулі
        double maxElement = matrix[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == maxElement)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        // Виведення результуючої матриці
        Console.WriteLine("Результуюча матриця:");
        PrintMatrix(matrix);
    }

  
  static void Task3()
    {
        int n;

        Console.WriteLine("Задання 3: Введіть кількість елементів послідовності:");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Помилка: введіть натуральне число для кількості елементів.");
        }

        double[] sequence = new double[n];
        bool validInput = false;

        do
        {
            Console.WriteLine("Введіть елементи послідовності (через пробіл):");
            string[] input = Console.ReadLine().Split(' ');

            if (input.Length == n)
            {
                validInput = true;

                // Заповнення масиву
                for (int i = 0; i < n; i++)
                {
                    sequence[i] = double.Parse(input[i]);
                }

                int positiveNeighbors = 0;
                int zeroNeighbors = 0;

                for (int i = 1; i < n; i++)
                {
                    if (sequence[i] > 0 && sequence[i - 1] > 0)
                    {
                        positiveNeighbors++;
                    }
                    if (sequence[i] == 0 && sequence[i - 1] == 0)
                    {
                        zeroNeighbors++;
                    }
                }

                Console.WriteLine($"Кількість сусідств двох додатних чисел: {positiveNeighbors}");
                Console.WriteLine($"Кількість сусідств двох нульових елементів: {zeroNeighbors}");
            }
            else
            {
                Console.WriteLine($"Помилка: очікується {n} елементів, але введено {input.Length}.");
            }
        } while (!validInput);
    }
    static void PrintMatrix(double[,] matrix)
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
