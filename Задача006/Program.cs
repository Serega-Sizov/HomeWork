// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Берем числа до 100000
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 99)
    {
        Console.Write($"В числе {num} нет третьей цифры");
    }

if (num < 1000 && num > 99)
    {
        Console.Write($"Из числа {num} третья цифра {num%10}");
    }
if (num >= 1000 && num < 10000)
    {
        Console.Write($"Из числа {num} третья цифра {(num/10)%10}");
    }
if (num >= 10000 && num < 100000)
    {
        Console.Write($"Из числа {num} третья цифра {(num/100)%10}");
    }
if (num > 100000)
    {
        Console.Write($"Число {num} больше 100 000");
    }