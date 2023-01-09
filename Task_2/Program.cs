// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите X1 для точки А: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1 для точки А: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1 для точки А: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите X2 для точки В: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2 для точки В: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z2 для точки В: ");
int z2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"d={d:f3}");