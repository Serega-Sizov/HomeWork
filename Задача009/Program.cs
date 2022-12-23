// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату точки А(х): ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки А(y): ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки А(z): ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Введите координату точки B(х): ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки B(y): ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки B(z): ");
int z2 = int.Parse(Console.ReadLine()!);

double res = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);

Console.Write($"Расстояние между точками А и В в 3D пространстве равно {res}");