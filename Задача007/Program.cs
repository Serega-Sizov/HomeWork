﻿// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.  
// Обязательна проверка на ввод числа <1 и >7
// 6 -> да
// 7 ->  да
// 1 -> нет

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 1 || number > 7)
    {
        Console.Write("Неверно введено число, введите от 1 до 7");
    }


if (number == 6 || number == 7)
    {
        Console.Write($"Введенное число {number} --> выходной день");
    }
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
    {
        Console.Write($"Введенное число {number} --> Будний день");
    }
