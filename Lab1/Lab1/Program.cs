using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("\nChoose Task:");
                Console.WriteLine("1. Calculate the arithmetic mean of two numbers");
                Console.WriteLine("2. Display text");
                Console.WriteLine("3. Check if the number is even");
                Console.WriteLine("4. Count the digits and sum of the digits of the number");
                Console.WriteLine("5. Reverse the number");
                Console.WriteLine("6. Display the sum of the digits of the number");
                Console.WriteLine("7. Exit the program");
                Console.Write("Your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CalculateAverage();
                        break;
                    case 2:
                        DisplayText();
                        break;
                    case 3:
                        CheckEvenNumber();
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
                    case 7:
                        continueRunning = false;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CalculateAverage()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2) / 2;
            Console.WriteLine("Arithmetic mean: " + average);
        }

        static void DisplayText()
        {
            Console.WriteLine("To be or not to be\n\\ Shakespeare \\");
        }

        static void CheckEvenNumber()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }

        static void CountDigitsAndSum()
        {
            Console.WriteLine("Enter a number (less than 100):");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 100)
            {
                int digitsCount = num.ToString().Length;
                int sum = 0;

                foreach (char c in num.ToString())
                {
                    sum += int.Parse(c.ToString());
                }

                Console.WriteLine("Number of digits: " + digitsCount);
                Console.WriteLine("Sum of digits: " + sum);
            }
            else
            {
                Console.WriteLine("The number must be less than 100.");
            }
        }

        static void ReverseNumber()
        {
            Console.WriteLine("Enter a number:");
            string num = Console.ReadLine();

            char[] reversed = num.ToCharArray();
            Array.Reverse(reversed);

            Console.WriteLine("Reversed number: " + new string(reversed));
        }

        static void SumDigits()
        {
            Console.WriteLine("Enter a number:");
            string num = Console.ReadLine();

            int sum = 0;

            foreach (char c in num)
            {
                sum += int.Parse(c.ToString());
            }

            Console.WriteLine("Sum of the digits: " + sum);
        }
    }
}
