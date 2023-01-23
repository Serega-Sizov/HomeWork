// Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве,
// а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] massiv = GetArray(rows, columns, 0, 10);
PrintArray(massiv);

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Numbers(num, massiv);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] resualt = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resualt[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return resualt;
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

void Numbers(int num, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                Console.WriteLine($"Число {num} есть в массиве.");
                
            }
            else
            {
                Console.WriteLine($"Число {num} НЕТ в массиве.");
            }
        }
    }
}

