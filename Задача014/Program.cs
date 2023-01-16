﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// ---создаем метод вызывающий массив из трехзначных чисел---
int[] GetArray(int size)
    {
        int[] res = new int[size];
        for (int i = 0; i < size; i++)
        {
            res[i] = new Random().Next(100, 1000);
        }
        return res;
    }

Console.Write("Введите длину массива: ");
int d = int.Parse(Console.ReadLine()!);
int[] array = GetArray(d);

Console.WriteLine($"[{String.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine($"В этом массиве {count} чётных чисел");