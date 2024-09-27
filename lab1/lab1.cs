using System;

class Program
{
    static void Main()
    {
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
