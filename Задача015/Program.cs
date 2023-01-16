// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(0, 1000);
            }
        return array;
    }
Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = GetArray(a);
Console.WriteLine($"[{String.Join(", ", array)}]");
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
Console.WriteLine($"Сумма чисел, стоящих под нечетными индексами, равна {sum}");
