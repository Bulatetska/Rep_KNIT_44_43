using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть завдання (1-6): ");
        Console.WriteLine("1. Середнє арифметичне: ");
        Console.WriteLine("2. Виведення на екран: ");
        Console.WriteLine("3. Перевірка парності: ");
        Console.WriteLine("4. Кількість та сума цифр: ");
        Console.WriteLine("5. Перевернути число: ");
        Console.WriteLine("6. Сума цифр: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateAverage();
                break;
            case 2:
                PrintText();
                break;
            case 3:
                CheckEven();
                break;
            case 4:
                CountDigitsAndSum();
                break;
            case 5:
                ReverseNumber();
                break;
            case 6:
                SumDigits();
                break;
            default:
                Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                break;
        }
    }

    static void CalculateAverage()
    {
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2) / 2;
        Console.WriteLine($"Середнє арифметичне: {average}");
    }

    static void PrintText()
    {
        Console.WriteLine("To be or not to be");
        Console.WriteLine("\\ Shakespeare \\");
    }

    static void CheckEven()
    {
        Console.Write("Введіть число: ");
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

    static void CountDigitsAndSum()
    {
        Console.Write("Введіть натуральне число (менше 100): ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 100)
        {
            Console.WriteLine("Число має бути менше 100.");
            return;
        }

        int digitCount = number.ToString().Length;
        int sumOfDigits = 0;

        foreach (char digit in number.ToString())
        {
            sumOfDigits += int.Parse(digit.ToString());
        }

        Console.WriteLine($"Кількість цифр: {digitCount}");
        Console.WriteLine($"Сума цифр: {sumOfDigits}");
    }

    static void ReverseNumber()
    {
        Console.Write("Введіть число: ");
        string input = Console.ReadLine();

        char[] reversedArray = input.ToCharArray();
        Array.Reverse(reversedArray);
        string reversedNumber = new string(reversedArray);

        Console.WriteLine($"Число навпаки: {reversedNumber}");
    }

    static void SumDigits()
    {
        Console.Write("Введіть число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sumOfDigits = 0;
        foreach (char digit in number.ToString())
        {
            sumOfDigits += int.Parse(digit.ToString());
        }

        Console.WriteLine($"Сума цифр числа: {sumOfDigits}");
    }
}
