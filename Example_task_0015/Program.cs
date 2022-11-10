// Вычислить периметр и площадь прямоугольного треугольника по заданным длинам двух катетов а и b.

double a, b, s, c ,p;

Console.WriteLine("Введите 1е : ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 2е : ");
b = Convert.ToDouble(Console.ReadLine());
s = a * b / 2;
c = Math.Sqrt(a * a + b * b);
p = a + b + c;
Console.WriteLine("Периметр " + p);
Console.WriteLine("Площадь " + s);