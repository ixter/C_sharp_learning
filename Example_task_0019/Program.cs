// Известны координаты на плоскости двух точек (x1, y1 и x2, y2). Составить программу вычисления расстояния между ними.

int xa, xb, ya, yb, result;
Console.Write("Введите координаты x1: ");
xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y1: ");
ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты x2: ");
xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y2: ");
yb = Convert.ToInt32(Console.ReadLine());

result = (int)Math.Abs(Math.Sqrt(Math.Pow(xa-xb,2) + Math.Pow(ya-yb,2)));

Console.WriteLine("расстояние между точками = " + result);