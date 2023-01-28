// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = Array1(2, 2);
PrintArray(matrix1);
System.Console.WriteLine();
int[,] matrix2 = Array2(2, 2);
PrintArray(matrix2);
System.Console.WriteLine();
PrintArray(DivArray(matrix1, matrix2));


int[,] Array1(int row, int colum)
{
    int[,] array = new int[row, colum];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}

int[,] Array2(int row, int colum)
{
    int[,] array = new int[row, colum];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}

int[,] DivArray(int[,] array1, int[,] array2)
{
    int[,] newarray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(0) == array2.GetLength(1))
    {
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                newarray[i, j] = 0;
                for (int n = 0; n < array1.GetLength(0); n++)
                {
                    newarray[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }
    }
    else Console.WriteLine("Введена не квадратная матрица");
    return newarray;
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