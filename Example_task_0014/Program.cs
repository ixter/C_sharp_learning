// Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.

double x, y, F1, F2;
 
Console.Write("Введите 2 числа для вычисления среднего арифметического и среднего геометрического: "); 
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
F1 = (Math.Abs(x) + Math.Abs(y)) / 2;     //Вычисляем среднее арифметическое
F2 = Math.Sqrt(x * y);   //Вычисляем среднее геометрическое
Console.WriteLine("Среднее арифметическое= " + F1); 
Console.WriteLine("Среднее геометрическое= " + F2);