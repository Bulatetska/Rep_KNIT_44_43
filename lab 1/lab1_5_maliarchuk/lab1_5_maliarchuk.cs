using System;

class Numbers {
static void Main() {

Console.Write ("Введіть число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = 0;

while (num != 0) {
int digit = num % 10;
num2 = num2 * 10 + digit;
num /= 10;
}

Console.Write ("Перевернуте число: " + num2);
}
}