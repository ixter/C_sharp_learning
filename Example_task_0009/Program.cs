// Составить программу обмена значениями двух переменных величин.

int a,b,c;
Console.WriteLine("Введите А и B = ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = a;
a = b;
b = c;
Console.WriteLine("A = "+ a +"   B = " + b);


Console.WriteLine("Введите А и B = ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
a = a+b;
b = a-b;
a = a-b;
Console.WriteLine("A = " + a + "   B = " + b);
