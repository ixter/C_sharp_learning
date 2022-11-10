// Составить программу обмена значениями трех переменных величин а, b, c
// по следующей схеме:
// b присвоить значение c,
// а присвоить значение b,
// с присвоить значение а.

int a,b,c,d;
Console.WriteLine("Введите А и B и С= ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = b;

b = c;
c = a;
a = d;
Console.WriteLine("A = "+ a +"   B = " + b +"   C = " + c);