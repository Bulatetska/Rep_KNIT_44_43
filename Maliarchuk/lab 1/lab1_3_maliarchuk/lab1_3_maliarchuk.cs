using System;

class IsEven {
static void Main() {
Console.Write ("Введіть число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
Console.Write ("Число парне");
} else {
Console.Write ("Число непарне");
}
}
}