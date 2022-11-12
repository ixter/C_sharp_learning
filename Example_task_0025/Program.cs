// Вычислить периметр и площадь прямоугольника по заданным пользователем длинам сторон.

int a,b,S,P;
Console.WriteLine("Введите длину прямоуг (а): ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину прямоуг (b): ");
b = Convert.ToInt32(Console.ReadLine());
S = a*b;
P = (a+b)*2;
Console.WriteLine("p= " + P);
Console.WriteLine("s= " + S);