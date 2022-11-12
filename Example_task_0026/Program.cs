// Дано вещественное число а. Пользуясь только операцией умножения, получить: а^15 за пять операций.

int b, a, c;
Console.Write("Введите число возводимое в степень: ");
a = Convert.ToInt32(Console.ReadLine());
b = a * a;
Console.WriteLine("квадрат = " + b);
c = b * a;
Console.WriteLine("куб = " + c);
b = b * c;
Console.WriteLine("пятая степень = " + b);
c = b * b;
Console.WriteLine("десятая степень = " + c);
b = b * c;
Console.WriteLine("пятнадцатая степень = " + b);