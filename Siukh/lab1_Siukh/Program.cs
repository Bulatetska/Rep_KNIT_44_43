using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Siukh {
    internal class Program {
        static void Main(string[] args) {

            //1 task:

            Console.WriteLine("Task 1: \n Enter the first number: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double b1 = double.Parse(Console.ReadLine());

            double result1 = (a1 + b1) / 2;
            Console.WriteLine("Result: " + result1);



            //2 task:

            Console.WriteLine("Task 2: \n To be or not to be \n \\Shakespeare\\");



            //3 task:

            Console.WriteLine("Task 3: \n Enter a number: ");
            double Numb3 = double.Parse(Console.ReadLine());
            if (Numb3 % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is not even");
            }



            //4 task:

            Console.WriteLine("Task 4: \n Enter a number: ");
            int a4 = int.Parse(Console.ReadLine());
            int count4 = 0;
            int result4 = 0;
            while (a4 > 0)
            {
                result4 += a4 % 10;
                a4 /= 10;
                count4++;
            }

            Console.WriteLine("\n Count of digits = " + count4 + "\n Sum of this digits = " + result4);



            // 5 task: 

            Console.WriteLine("Task 5: \n Enter a number: ");
            string consoleRead = Console.ReadLine();
            int a5 = int.Parse(consoleRead);
            int length5 = consoleRead.Length;

            Console.WriteLine("Result of task 5:");

            for (int i = 0; i < length5; i++)
            {
                Console.Write(a5 % 10);
                a5 /= 10;
            }
            Console.WriteLine("\n");

            // 6 task: 

            Console.WriteLine("Task 6: \n Enter a number: ");
            int a6 = int.Parse(Console.ReadLine());
            int result6 = 0;
            while (a6 > 0)
            {
                result6 += a6 % 10;
                a6 /= 10;
            }

            Console.WriteLine("Result = " + result6);
        }
    }
}
