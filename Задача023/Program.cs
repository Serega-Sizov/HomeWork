// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int[,] massiv = GetArray(num, num);
PrintArray(massiv);

int[] lineAmount = sum(massiv);
Console.WriteLine();
Console.WriteLine($"{String.Join(" ", lineAmount)}");

int min = lineAmount.Max();
int index = 0;
for (int i = 0; i < lineAmount.Length; i++)
    if (min > lineAmount[i])
    {
        min = lineAmount[i];
        index = i;
    }
Console.WriteLine($"Наименьшая сумма элементов в {index + 1} строке.");

// ---методы---
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] sum(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = 0;
            for (int n = 0; n < array.GetLength(0); n++)
            {
                sum[i] += array[i, n];
            }
        }
    }
    return sum;
}