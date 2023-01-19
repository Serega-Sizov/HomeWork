// Домашнее задание
// --------------ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ--------------



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число : ");
double A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
double B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно {GetDegree(A, B)}");

double GetDegree (double num, double rank)
{
    if (B == 0) return 1;

    double resualt = 1;
    for (int i = 1; i <= rank; i++)
    {
        resualt *=num;
    }
    return resualt;
}
// Console.WriteLine();