using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Оберіть лабораторну");
        Console.WriteLine("1 - Лабораторна 1");
            Console.WriteLine("2 - Лабораторна 2");
            Console.WriteLine("3 - Лабораторна 3"); 
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Task1.Run(); 
        }
        else if (choice == "2")
        {
            Task2.Run(); 
        }
        else if (choice == "3")
        {
            Task3.Run();  
        }
    }
}
public class Task1
{
    public static void Run()
    {
        Console.WriteLine("Це лаборторна 1.");
        while (true)
        {
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1 - Обчислити середнє арифметичне двох чисел");
            Console.WriteLine("2 - Вивести текст");
            Console.WriteLine("3 - Перевірити число на парність");
            Console.WriteLine("4 - Кількість цифр та сума цифр числа");
            Console.WriteLine("5 - Перевернути число");
            Console.WriteLine("6 - Показати суму цифр числа");
            Console.WriteLine("0 - Вийти з програми");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CalculateAverage();
                    break;
                case "2":
                    PrintText();
                    break;
                case "3":
                    CheckEvenOrOdd();
                    break;
                case "4":
                    CountDigitsAndSum();
                    break;
                case "5":
                    ReverseNumber();
                    break;
                case "6":
                    SumDigits();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неправильний вибір, спробуйте ще раз.");
                    break;
            }

            Console.WriteLine(); // Додатковий пропуск рядка для кращої читабельності
        }
    }

    // Завдання 1: Обчислити середнє арифметичне двох чисел
    static void CalculateAverage()
    {
        Console.WriteLine("Введіть перше число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double average = (number1 + number2) / 2;
        Console.WriteLine($"Середнє арифметичне: {average}");
    }

    // Завдання 2: Вивести текст
    static void PrintText()
    {
        Console.WriteLine("To be or not to be");
        Console.WriteLine("\\ Shakespeare \\");
    }

    // Завдання 3: Перевірка числа на парність
    static void CheckEvenOrOdd()
    {
        Console.WriteLine("Введіть число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Число парне.");
        }
        else
        {
            Console.WriteLine("Число непарне.");
        }
    }

    // Завдання 4: Кількість цифр та сума цифр числа
    static void CountDigitsAndSum()
    {
        Console.WriteLine("Введіть натуральне число (менше 100):");
        int a = Convert.ToInt32(Console.ReadLine());

        int digitCount = a.ToString().Length;
        int sumOfDigits = 0;

        while (a > 0)
        {
            sumOfDigits += a % 10;
            a /= 10;
        }

        Console.WriteLine($"Кількість цифр: {digitCount}");
        Console.WriteLine($"Сума цифр: {sumOfDigits}");
    }

    // Завдання 5: Перевернути число
    static void ReverseNumber()
    {
        Console.WriteLine("Введіть число:");
        string input = Console.ReadLine();
        char[] reversed = input.ToCharArray();
        Array.Reverse(reversed);

        Console.WriteLine($"Число навпаки: {new string(reversed)}");
    }

    // Завдання 6: Сума цифр числа
    static void SumDigits()
    {
        Console.WriteLine("Введіть число:");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine($"Сума цифр числа: {sum}");
    }
}
  
public class Task2
{
    public static void Run()
    {
        Console.WriteLine("Це лабораторна 2");
        Console.WriteLine("Завдання 1: Одновимірний масив - кількість максимальних елементів та перший індекс.");
        Task1();

        Console.WriteLine("\nЗавдання 2: Квадратна матриця - замінити м2аксимальні елементи на нулі.");
        Task_2();

        Console.WriteLine("\nЗавдання 3: Послідовність чисел - кількість сусідніх пар додатних та нульових елементів.");
        Task3();

        Console.WriteLine("\nЗавдання 4: Прямокутна матриця - замінити елементи менші та більші за середнє арифметичне.");
        Task4();

        Console.WriteLine("\nЗавдання 5: Матриця 6x9 - сума елементів рядка з найбільшим елементом.");
        Task5();

        Console.WriteLine("\nЗавдання 6: Одновимірний масив - сума елементів.");
        Task6();
    }

    // Завдання 1
    static void Task1()
    {
        int[] A = { 3, 5, 9, 1, 9, 7, 9 };

        int maxElement = A.Max();
        int countMax = A.Count(x => x == maxElement);
        int firstIndex = Array.IndexOf(A, maxElement);

        Console.WriteLine($"Максимальний елемент: {maxElement}");
        Console.WriteLine($"Кількість появ: {countMax}");
        Console.WriteLine($"Індекс першої появи: {firstIndex}");
    }

    // Завдання 2
    static void Task_2()
    {
        double[,] matrix = {
            { 1.2, 3.5, 2.3 },
            { 4.1, 5.6, 5.6 },
            { 0.9, 4.2, 5.6 }
        };

        int n = matrix.GetLength(0);
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

        Console.WriteLine("\nМатриця після заміни максимальних елементів:");
        PrintMatrix(matrix);
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Завдання 3
    static void Task3()
    {
        double[] sequence = { 1.5, 0, 3.4, 0, 0, 2.3, -1, 0 };

        int positivePairs = 0;
        int zeroPairs = 0;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > 0 && sequence[i + 1] > 0)
                positivePairs++;

            if (sequence[i] == 0 && sequence[i + 1] == 0)
                zeroPairs++;
        }

        Console.WriteLine($"Кількість пар додатних елементів: {positivePairs}");
        Console.WriteLine($"Кількість пар нульових елементів: {zeroPairs}");
    }

    // Завдання 4
    static void Task4()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        double sum = 0;
        foreach (int value in matrix)
        {
            sum += value;
        }

        double average = sum / (n * m);
        Console.WriteLine($"Середнє арифметичне: {average}");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < average)
                    matrix[i, j] = -1;
                else
                    matrix[i, j] = 1;
            }
        }

        Console.WriteLine("Матриця після заміни:");
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Завдання 5
    static void Task5()
    {
        int[,] matrix = new int[6, 9]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 9, 8, 7, 6, 5, 4, 3, 2, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            { 5, 4, 3, 2, 1, 0, -1, -2, -3 },
            { 6, 5, 4, 3, 2, 1, 0, -1, -2 }
        };

        int maxElement = int.MinValue;
        int maxRowIndex = 0;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    maxRowIndex = i;
                }
            }
        }

        int sum = 0;
        for (int j = 0; j < 9; j++)
        {
            sum += matrix[maxRowIndex, j];
        }

        Console.WriteLine($"Найбільший елемент: {maxElement}");
        Console.WriteLine($"Сума елементів рядка з найбільшим елементом: {sum}");
    }

    // Завдання 6
    static void Task6()
    {
        double[] array = { 1.5, 2.3, -4.0, 5.5, 6.7 };

        double sum = 0;
        foreach (double value in array)
        {
            sum += value;
        }

        Console.WriteLine($"Сума елементів масиву: {sum}");
    }
    }

public class Task3
{
    public static void Run()
    {
        List<Hero> heroes = GetSuperheroes();

        // 1. Імена супергероїв, які народилися в 1941 р.
        Console.WriteLine("Завдання 1: Імена супергероїв, які народилися в 1941 році:");

        // Імперативний спосіб
        Console.WriteLine("Імперативний спосіб:");
        foreach (var hero in heroes)
        {
            if (hero.YearOfBirth == 1941)
            {
                Console.WriteLine(hero.Name);
            }
        }

        // Декларативний спосіб (LINQ)
        Console.WriteLine("Декларативний спосіб (LINQ):");
        var heroesBornIn1941 = heroes
            .Where(hero => hero.YearOfBirth == 1941)
            .Select(hero => hero.Name);

        foreach (var hero in heroesBornIn1941)
        {
            Console.WriteLine(hero);
        }

        // 2. Назви коміксів, відсортовані в алфавітному порядку
        Console.WriteLine("\nЗавдання 2: Назви коміксів в алфавітному порядку:");

        // Імперативний спосіб
        Console.WriteLine("Імперативний спосіб:");
        List<string> comicsTitlesImperative = new List<string>();
        foreach (var hero in heroes)
        {
            if (!comicsTitlesImperative.Contains(hero.Comics))
            {
                comicsTitlesImperative.Add(hero.Comics);
            }
        }
        comicsTitlesImperative.Sort();

        foreach (var title in comicsTitlesImperative)
        {
            Console.WriteLine(title);
        }

        // Декларативний спосіб (LINQ)
        Console.WriteLine("Декларативний спосіб (LINQ):");
        var comicsTitlesDeclarative = heroes
            .Select(hero => hero.Comics)
            .Distinct()
            .OrderBy(title => title);

        foreach (var title in comicsTitlesDeclarative)
        {
            Console.WriteLine(title);
        }

        // 3. Імена супергероїв та дати їх народження, відсортовані в порядку спадання
        Console.WriteLine("\nЗавдання 3: Імена супергероїв та дати народження (за спаданням):");

        // Імперативний спосіб
        Console.WriteLine("Імперативний спосіб:");
        List<Hero> sortedHeroesImperative = new List<Hero>(heroes);
        sortedHeroesImperative.Sort((x, y) => y.YearOfBirth.CompareTo(x.YearOfBirth));

        foreach (var hero in sortedHeroesImperative)
        {
            Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
        }

        // Декларативний спосіб (LINQ)
        Console.WriteLine("Декларативний спосіб (LINQ):");
        var heroesSortedByBirthDate = heroes
            .OrderByDescending(hero => hero.YearOfBirth)
            .Select(hero => $"{hero.Name} - {hero.YearOfBirth}");

        foreach (var hero in heroesSortedByBirthDate)
        {
            Console.WriteLine(hero);
        }
    }

    private static List<Hero> GetSuperheroes()
    {
        // Імітація бази даних супергероїв
        return new List<Hero>
        {
            new Hero { Name = "Batman", YearOfBirth = 1939, Comics = "DC" },
            new Hero { Name = "Wonder Woman", YearOfBirth = 1941, Comics = "DC" },
            new Hero { Name = "Spider-Man", YearOfBirth = 1962, Comics = "Marvel" },
            new Hero { Name = "Captain America", YearOfBirth = 1941, Comics = "Marvel" },
            new Hero { Name = "Superman", YearOfBirth = 1938, Comics = "DC" }
        };
    }
}

// Клас для супергероя
public class Hero
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
    public string Comics { get; set; }
}