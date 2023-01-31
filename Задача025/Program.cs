// Задача 64: Выполнить с помощью рекурсии.
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Numbers(N, 1));
// // ---Метод---
// string Numbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + Numbers(start - 1, 1));
// }
// ---------------------------------------------------

// Задача 66: Выполнить с помощью рекурсии.
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SumNumbers(M, N));

// // ---Метод---
// int SumNumbers(int M, int N)
// {
//     if (M == N) return M;
//     return N + SumNumbers(M, N - 1);
// }
// ---------------------------------------------------

// Задача 68: Выполнить с помощью рекурсии.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Akk(M, N));

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
  if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
