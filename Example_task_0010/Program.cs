// Составить программу обмена значениями трех переменных величин а, b, c
// по следующей схеме:
// b присвоить значение а,
// с присвоить значение b,
// а присвоить значение с.

int a,b,c,d;
Console.WriteLine("Введите А и B и С= ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = a;
a = c;
c = b;
b = d;
Console.WriteLine("A = "+ a +"   B = " + b +"   C = " + c);