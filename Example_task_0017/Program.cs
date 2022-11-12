// Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int dist = 0;
// формула  L = корень((x1-x2)[в квадрате])
dist = (int)Math.Sqrt((Math.Pow(x1-x2,2)));
Console.WriteLine(dist);