// Найти площадь треугольника, две стороны которого равны а и b, а угол между этими сторонами равен g

int a, b, g;
double s;
double pi=Math.PI;

Console.Write("Длина стороны а: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Длина стороны b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Угол: ");
g = Convert.ToInt32(Console.ReadLine());
s = 0.5*a*b*Math.Sin(g*pi/180);
Console.WriteLine("S= " + s);