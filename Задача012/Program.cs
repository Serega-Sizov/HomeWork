// Домашнее задание
// --------------ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ--------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetSum (int num)
{
    int sum = 0;
    for(int i = 0; i <= num; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int nu = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел в числе {nu} равна {GetSum(nu)}");
