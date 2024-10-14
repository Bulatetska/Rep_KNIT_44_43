using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберіть, яку програму запустити:");
        Console.WriteLine("1 - Середнє арифметичне двох чисел");
        Console.WriteLine("2 - Вивести текст");
        Console.WriteLine("3 - Перевірка парності числа");
        Console.WriteLine("4 - Кількість і сума цифр числа");
        Console.WriteLine("5 - Перевернути число");
        Console.WriteLine("6 - Сума цифр числа");
        Console.Write("Ваш вибір: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                AverageOfTwoNumbers();
                break;
            case "2":
                PrintText();
                break;
            case "3":
                CheckParity();
                break;
            case "4":
                CountAndSumDigits();
                break;
            case "5":
                ReverseNumber();
                break;
            case "6":
                SumOfDigits();
                break;
            default:
                Console.WriteLine("Неправильний вибір.");
                break;
        }
    }

    static void AverageOfTwoNumbers()
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

    static void CheckParity()
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

    static void CountAndSumDigits()
    {
        Console.Write("Введіть натуральне число (a < 100): ");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a > 0 && a < 100)
        {
            int count = a.ToString().Length;
            int sum = 0;

            foreach (char digit in a.ToString())
            {
                sum += (int)char.GetNumericValue(digit);
            }

            Console.WriteLine($"Кількість цифр: {count}");
            Console.WriteLine($"Сума цифр: {sum}");
        }
        else
        {
            Console.WriteLine("Число повинно бути натуральним і менше 100.");
        }
    }

    static void ReverseNumber()
    {
        Console.Write("Введіть число: ");
        string number = Console.ReadLine();
        char[] reversedArray = number.ToCharArray();
        Array.Reverse(reversedArray);
        string reversedNumber = new string(reversedArray);
        Console.WriteLine($"Перевернуте число: {reversedNumber}");
    }

    static void SumOfDigits()
    {
        Console.Write("Введіть число: ");
        string number = Console.ReadLine();
        int sum = 0;

        foreach (char digit in number)
        {
            sum += (int)char.GetNumericValue(digit);
        }

        Console.WriteLine($"Сума цифр числа: {sum}");
    }
}
