// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] GetArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(1, 10);
            }
        return array;
    }
Console.Write($"Введите количество элементов в массиве: ");
int s = int.Parse(Console.ReadLine()!);
int[] array = GetArray(s);
Console.WriteLine($"[{String.Join(", ", array)}]");

int n = array.Length;
int m = array.Length / 2;

for (int i = 0; i < m; i++)
{
    int sum = 0;
    sum = array[i] * array[n - i - 1];
    int[] res = new int[] {sum};
    Console.Write($"[{String.Join(", ", res)}]");
}
