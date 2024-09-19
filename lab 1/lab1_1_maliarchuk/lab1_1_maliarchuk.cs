using System;

class AvrNum {
static void Main() {
Console.Write ("Введіть перше число: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write ("Введіть друге число: ");
double n2 = Convert.ToDouble(Console.ReadLine());

double avr = (n1 + n2)/2;
Console.Write ("Середнє арифметичне двох чисел: " + avr);
}
} 