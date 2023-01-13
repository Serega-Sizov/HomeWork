// Домашнее задание
// --------------ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ--------------



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
double A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
double B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно {GetDegree(A, B)}");

double GetDegree (double A, double B)
{
    double num = Math.Pow(A, B);
    return num;
}
