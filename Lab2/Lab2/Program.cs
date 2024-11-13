using System;

class Program
{
    static void Main(string[] args)
    {
        // Завдання 1: Обчислення середнього арифметичного двох чисел
        Console.WriteLine("Завдання 1: Середнє арифметичне двох чисел");
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double average = (num1 + num2) / 2;
        Console.WriteLine("Середнє арифметичне: " + average);

        Console.WriteLine();

        // Завдання 2: Виведення тексту на екран
        Console.WriteLine("Завдання 2: Виведення тексту на екран");
        Console.WriteLine("To be or not to be");
        Console.WriteLine("\\ Shakespeare \\");

        Console.WriteLine();

        // Завдання 3: Перевірка на парність
        Console.WriteLine("Завдання 3: Перевірка на парність");
        Console.Write("Введіть число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Число парне");
        }
        else
        {
            Console.WriteLine("Число непарне");
        }

        Console.WriteLine();

        // Завдання 4: Кількість цифр та сума цифр у числі a (a < 100)
        Console.WriteLine("Завдання 4: Кількість цифр та сума цифр числа");
        Console.Write("Введіть число (a < 100): ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a < 10)
        {
            Console.WriteLine("Кількість цифр: 1");
            Console.WriteLine("Сума цифр: " + a);
        }
        else if (a < 100)
        {
            int sum = (a / 10) + (a % 10);
            Console.WriteLine("Кількість цифр: 2");
            Console.WriteLine("Сума цифр: " + sum);
        }
        else
        {
            Console.WriteLine("Число більше або рівне 100");
        }

        Console.WriteLine();

        // Завдання 5: Перевернути число
        Console.WriteLine("Завдання 5: Перевернути число");
        Console.Write("Введіть число: ");
        string input = Console.ReadLine();
        char[] reversedArray = input.ToCharArray();
        Array.Reverse(reversedArray);
        string reversed = new string(reversedArray);
        Console.WriteLine("Перевернуте число: " + reversed);

        Console.WriteLine();

        // Завдання 6: Сума цифр числа
        Console.WriteLine("Завдання 6: Сума цифр числа");
        Console.Write("Введіть число: ");
        string inputNum = Console.ReadLine();
        int sumDigits = 0;
        foreach (char digit in inputNum)
        {
            sumDigits += int.Parse(digit.ToString());
        }
        Console.WriteLine("Сума цифр числа: " + sumDigits);
    }
}
