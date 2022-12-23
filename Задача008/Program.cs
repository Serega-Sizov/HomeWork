// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
string text = num.ToString();
char[] ar = text.ToCharArray(); //создали массив символов с типом char, чтоб по одному символу считать нашу строку. 
                                // Конвертируем текст из строкового формата в символьный массив благодаря .ToCharArray.

Array.Reverse(ar); //переворачиваем массив.
string finaltext = new String(ar); //преобразовываем число в строку.


if (text.Length != 5)
    {
        Console.WriteLine("!!!Неверно введено число!!!");
    }
else if (finaltext == text)
    {
        Console.WriteLine($"Введенное число {text} является палиндромом");
    }
else
    {
        Console.WriteLine($"Введенное число {text} не является палиндромом");
    }





// int[] numbers = { 1, 2, 3, 5};
// Console.WriteLine($"{numbers[^1]}{numbers[^2]}{numbers[^3]}");  // 5 - первый с конца или последний элемент
// Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
// Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца






