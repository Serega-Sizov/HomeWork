// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.

// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9


// -----Методы-----

// получить массив
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue),1);
        }
    }
    return res;
}

// напечатать массив
void PrintArray(double[,] array)
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
// ---основной код---
// вводим количество строк и столбцов
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
// вызываем наш метод создания двумерного массива
double[,] arrray = GetArray(m, n, -10, 11);
// вызываем наш метод для вывода в терминал полученного массива
PrintArray(arrray);