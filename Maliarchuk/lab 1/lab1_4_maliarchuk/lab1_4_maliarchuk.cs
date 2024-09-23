using System;

class Numbers {
static void Main() {

Console.Write ("Введіть число a (a < 100): ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int count = 0;
int temp = a;

while (temp > 0) {
sum += temp % 10;
temp /= 10;
count++;
}

Console.Write ("Кількість цифр: " + count + '\n');
Console.Write ("Сума цифр: " + sum);
}
}