using System;

class Numbers {
static void Main() {

Console.Write ("Введіть число: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int temp = a;

while (temp > 0) {
sum += temp % 10;
temp /= 10;
}

Console.Write ("Сума цифр: " + sum);
}
}