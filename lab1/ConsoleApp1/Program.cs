class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть дію:");
        Console.WriteLine("1. Обчислити середнє арифметичне двох чисел.");
        Console.WriteLine("2. Вивести текст.");
        Console.WriteLine("3. Перевірити парність числа.");
        Console.WriteLine("4. Кількість цифр і сума цифр числа.");
        Console.WriteLine("5. Перевернути число.");
        Console.WriteLine("6. Сума цифр числа.");
        
        Console.Write("Ваш вибір: ");
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
                CheckParity();
                break;
            case 4:
                CountAndSumDigits();
                break;
            case 5:
                ReverseNumber();
                break;
            case 6:
                SumOfDigits();
                break;
            default:
                Console.WriteLine("Неправильний вибір.");
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
        Console.WriteLine("Lab1 Anna Halukh");
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

        if (a < 100 && a > 0)
        {
            int digitCount = a.ToString().Length;
            int sumOfDigits = 0;

            while (a > 0)
            {
                sumOfDigits += a % 10;
                a /= 10;
            }

            Console.WriteLine($"Кількість цифр: {digitCount}, Сума цифр: {sumOfDigits}");
        }
        else
        {
            Console.WriteLine("Число має бути натуральним і менше 100.");
        }
    }

    static void ReverseNumber()
    {
        Console.Write("Введіть число: ");
        string number = Console.ReadLine();

        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        string reversedNumber = new string(charArray);

        Console.WriteLine($"Перевернуте число: {reversedNumber}");
    }

    static void SumOfDigits()
    {
        Console.Write("Введіть число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sumOfDigits = 0;

        while (number > 0)
        {
            sumOfDigits += number % 10;
            number /= 10;
        }

        Console.WriteLine($"Сума цифр числа: {sumOfDigits}");
    }
}