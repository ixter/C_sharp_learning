// Вычислить расстояние между двумя точками с данными координатами (х1, у1) и (х2, у2).

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int dist = 0;
// формула  L = корень((x1-x2)[в квадрате] + (y1-y2)[в квадрате])
dist = (int)Math.Sqrt((Math.Pow(x1-x2,2)) + (Math.Pow(y1-y2, 2)));
Console.WriteLine(dist);