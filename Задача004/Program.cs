// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine()!);

int num1 = 1;

while(num1 <= number)
{
    if (num1 % 2 == 0)
    {
        Console.Write($"{num1} ");
    }
    num1++;
}
