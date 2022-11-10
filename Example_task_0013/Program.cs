// Найти произведение цифр заданного четырехзначного числа.

string? x;
Console.WriteLine("Введите символ: ");
x = Console.ReadLine();
if (x != null && x.Length == 4) {
    Console.WriteLine("Произведение цифр заданного четырехзначного числа: " + x[0] * x[1] * x[2] * x[3]);
}
else
{
    Console.WriteLine("Введите 4х значное число");
}