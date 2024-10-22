using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Завдання 1: Обчислення середнього арифметичного двох чисел");
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double average = (num1 + num2) / 2;
        Console.WriteLine("Середнє арифметичне: " + average);
        Console.WriteLine();

        Console.WriteLine("Завдання 2: Виведення тексту");
        Console.WriteLine("To be or not to be");
        Console.WriteLine("\\ Shakespeare \\");
        Console.WriteLine();

        Console.WriteLine("Завдання 3: Перевірка числа на парність");
        Console.Write("Введіть число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if (num3 % 2 == 0)
        {
            Console.WriteLine("Число парне");
        }
        else
        {
            Console.WriteLine("Число непарне");
        }
        Console.WriteLine();

        Console.WriteLine("Завдання 4: Виведення кількості цифр і суми цифр числа");
        Console.Write("Введіть число (a < 100): ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a >= 100)
        {
            Console.WriteLine("Число більше або рівне 100");
        }
        else
        {
            int digitCount = a.ToString().Length;
            int digitSum = 0;
            string aString = a.ToString();
            for (int i = 0; i < aString.Length; i++)
            {
                digitSum += int.Parse(aString[i].ToString());
            }
            Console.WriteLine($"Кількість цифр: {digitCount}");
            Console.WriteLine($"Сума цифр: {digitSum}");
        }
        Console.WriteLine();

        Console.WriteLine("Завдання 5: Перевернути число");
        Console.Write("Введіть число: ");
        string inputNumber = Console.ReadLine()!;
        char[] reversedNumber = inputNumber.ToCharArray();
        Array.Reverse(reversedNumber);
        Console.WriteLine("Перевернуте число: " + new string(reversedNumber));
        Console.WriteLine();

        Console.WriteLine("Завдання 6: Сума цифр числа");
        Console.Write("Введіть число: ");
        string inputNumber2 = Console.ReadLine()!;
        int sumOfDigits = 0;
        for (int i = 0; i < inputNumber2.Length; i++)
        {
            sumOfDigits += int.Parse(inputNumber2[i].ToString());
        }
        Console.WriteLine($"Сума цифр числа: {sumOfDigits}");
    }
}

