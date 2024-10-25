using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

class Program
{
static void Main( string[] args)

{
////// 1

double nm1, nm2, avr, number;
int a, count , sum;
Console.WriteLine("Task 1. the arithmetic mean of two numbers.:");
Console.Write ("Enter the first number: ");
nm1 = Convert.ToDouble(Console.ReadLine());

Console.Write ("Enter the second number: ");
nm2 = Convert.ToDouble(Console.ReadLine());

avr = (nm1 + nm2)/2;
Console.WriteLine ("The arithmetic mean of two numbers: {0:f2} \n\n", avr);
//////////// 2
Console.WriteLine("Task 2.");
Console.WriteLine("To be or not to be\n\\ Shakespeare \\\n\n");
////////// 3
Console.WriteLine("Task 3. even or odd number");
Console.Write ("Enter number: ");
number = Convert.ToDouble(Console.ReadLine());
if (number % 2 ==0)
{
Console.WriteLine ("The number is even \n\n");
}
else{
Console.WriteLine ("The number is not even \n\n");
}
/////// 4
Console.WriteLine("Task 4.");
Console.Write ("Enter number a( a < 100) : ");
a = Convert.ToInt32(Console.ReadLine());
if ( a < 1 || a >= 100){
Console.WriteLine ("The number must be a natural number and less than 100. ");
return;
}
count = a.ToString().Length;
int sumofDigits= 0;
int temp = a;
while(temp > 0){
sumofDigits+= temp % 10;
temp /=10;
}
sum = (a /10) + (a% 10);
Console.WriteLine ("Number of digits including: {0:f1}", count);
Console.WriteLine ("Sum of number a: {0:f1}\n\n", sum);

//////5
Console.WriteLine("Task 5.");
Console.Write ("Enter number  : ");
string input = Console.ReadLine();
char[] charArray = input.ToCharArray();
Array.Reverse(charArray);
string reversednumber = new string(charArray);
Console.WriteLine("Reversed number : \n\n" + reversednumber );

//////6
Console.WriteLine("Task 6.");
Console.Write ("Enter number  : ");
string nmbr = Console.ReadLine();
int sumnmbr = 0;
foreach(char digit in nmbr){
    if (char.IsDigit(digit)){
        sumnmbr+=(digit - '0');
    }
}
Console.WriteLine("Sum of digits "+ sumnmbr);
}
}

}

