﻿// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).



// ---Метод(рандомный массив от 0 до 100)---
int[] GetArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(0, 101);
            }
        return array;
    }



// ---ввод данных---
Console.Write("Введите размер массива: ");
int a = int.Parse(Console.ReadLine()!);
// ---присваиваем переменной наш метод---
var num = GetArray(a);
// ---выводим массив в терминал---
Console.WriteLine($"[{String.Join(", ", num)}]");
// ---сортируем массив---
Array.Sort(num);
// ---перебираем получившийся массив и выводи значения на экран---
foreach (var i in num) 
    Console.Write($"{i} ");