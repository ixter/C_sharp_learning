// Дан радиус окружности. Найти длину окружности и площадь круга.
double radius;

Console.Write("Введите R: ");
radius = Convert.ToDouble(Console.ReadLine());
// WriteLine принимает параметры( в формате {0}), 
// формула длинны окружности (2 * 3,14 * radius) сформатированием до сотых
// формула площади окружности (3,14 * Pow(возвращает число a, возведенное в степень b)) сформатированием до сотых
Console.WriteLine("\nРадиус: {0}. \nДлина окружности L: {1}. \nПлощадь круга S: {2}.\n", radius, (2 * Math.PI * radius).ToString("0.##"), (Math.PI * Math.Pow(radius, 2)).ToString("0.##"));
