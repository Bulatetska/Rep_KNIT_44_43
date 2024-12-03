using System;

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            // Виведення меню
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Calculate average of two numbers");
            Console.WriteLine("2. Display a specific text");
            Console.WriteLine("3. Check if a number is even or odd");
            Console.WriteLine("4. Count digits and sum digits of a number (less than 100)");
            Console.WriteLine("5. Reverse a number");
            Console.WriteLine("6. Calculate the sum of the digits of a number");
            Console.WriteLine("0. Exit");

            // Вибір користувача
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CalculateAverage();
                    break;
                case "2":
                    DisplayText();
                    break;
                case "3":
                    CheckEvenOdd();
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

    // Завдання 1: Обчислення середнього арифметичного двох чисел
    static void CalculateAverage()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2) / 2;
        Console.WriteLine($"The average of {num1} and {num2} is {average}");
    }

    // Завдання 2: Виведення тексту
    static void DisplayText()
    {
        Console.WriteLine("To be or not to be\n\\ Shakespeare \\");
    }

    // Завдання 3: Перевірка парності числа
    static void CheckEvenOdd()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }

    // Завдання 4: Підрахунок кількості цифр і суми цифр числа
    static void CountAndSumDigits()
    {
        Console.WriteLine("Enter a natural number less than 100:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100 && number >= 0)
        {
            string numberString = number.ToString();
            int digitCount = numberString.Length;

            int digitSum = 0;
            foreach (char digit in numberString)
            {
                digitSum += int.Parse(digit.ToString());
            }

            Console.WriteLine($"The number has {digitCount} digits and their sum is {digitSum}");
        }
        else
        {
            Console.WriteLine("Please enter a number less than 100.");
        }
    }

    // Завдання 5: Перевернути число
    static void ReverseNumber()
    {
        Console.WriteLine("Enter a number:");
        string number = Console.ReadLine();

        char[] reversed = number.ToCharArray();
        Array.Reverse(reversed);
        string reversedNumber = new string(reversed);

        Console.WriteLine($"Reversed number: {reversedNumber}");
    }

    // Завдання 6: Сума цифр числа
    static void SumOfDigits()
    {
        Console.WriteLine("Enter a number:");
        string number = Console.ReadLine();

        int sum = 0;
        foreach (char digit in number)
        {
            sum += int.Parse(digit.ToString());
        }

        Console.WriteLine($"The sum of the digits is: {sum}");
    }
}
