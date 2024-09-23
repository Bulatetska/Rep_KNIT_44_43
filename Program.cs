using System;

class Program
{
    static void Main()
    {
        // Завдання 1: Обчислення середнього арифметичного двох чисел
        Console.WriteLine("Завдання 1: Обчислення середнього арифметичного двох чисел");
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double average = (num1 + num2) / 2;
        Console.WriteLine($"Середнє арифметичне: {average}\n");

        // Завдання 2: Виведення тексту
        Console.WriteLine("Завдання 2: Виведення тексту");
        Console.WriteLine("To be or not to be");
        Console.WriteLine("\\ Shakespeare \\\n");

        // Завдання 3: Перевірка на парність
        Console.WriteLine("Завдання 3: Перевірка числа на парність");
        Console.Write("Введіть число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Число парне\n");
        }
        else
        {
            Console.WriteLine("Число непарне\n");
        }

        // Завдання 4: Кількість цифр та їх сума в числі
        Console.WriteLine("Завдання 4: Кількість цифр та їх сума в числі");
        Console.Write("Введіть натуральне число (a < 100): ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a < 100)
        {
            int digitCount = a.ToString().Length;
            int digitSum = 0;
            foreach (char c in a.ToString())
            {
                digitSum += c - '0'; // Перетворення символу в число
            }
            Console.WriteLine($"Кількість цифр: {digitCount}");
            Console.WriteLine($"Сума цифр: {digitSum}\n");
        }
        else
        {
            Console.WriteLine("Число більше або дорівнює 100. Спробуйте ще раз.\n");
        }

        // Завдання 5: Перевертання числа
        Console.WriteLine("Завдання 5: Перевертання числа");
        Console.Write("Введіть число: ");
        string inputNumber = Console.ReadLine();
        char[] numberArray = inputNumber.ToCharArray();
        Array.Reverse(numberArray);
        string reversedNumber = new string(numberArray);
        Console.WriteLine($"Перевернуте число: {reversedNumber}\n");

        // Завдання 6: Сума цифр числа
        Console.WriteLine("Завдання 6: Сума цифр числа");
        Console.Write("Введіть число: ");
        string numberForSum = Console.ReadLine();
        int sum = 0;
        foreach (char c in numberForSum)
        {
            sum += c - '0'; // Перетворення символу в число
        }
        Console.WriteLine($"Сума цифр числа: {sum}");
    }
}
