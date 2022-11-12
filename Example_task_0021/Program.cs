// Треугольник задается координатами своих вершин на плоскости: A(x1, y1), В(х2,у2), С(х3,y3).
// Найти площадь треугольника ABC.

int x1, y1, x2, y2, x3, y3, P, p2, S, a, b, c;

Console.Write("Координаты первой точки x1: ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты первой точки y1: ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Координаты первой точки x2: ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты первой точки y2: ");
y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Координаты первой точки x3: ");
x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты первой точки y3: ");
y3 = Convert.ToInt32(Console.ReadLine());

a=(int)Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
b=(int)Math.Sqrt(Math.Pow(x3-x2, 2)+Math.Pow(y3-y2, 2));
c=(int)Math.Sqrt(Math.Pow(x3-x1, 2)+Math.Pow(y3-y1, 2));
P=a+b+c;
p2=P/2;
S=(int)Math.Sqrt(p2*(p2-a)*(p2-b)*(p2-c));
Console.WriteLine("Площадь: " + S);