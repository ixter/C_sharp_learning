// Составить программу вывода на экран «столбиком»
// пяти любых чисел, введенных пользователем с клавиатуры.
int count = 0;
int i;
int[] myArr = new int[5];
Console.WriteLine("Введите 5 любых чисел:");
while (count <= 4)
{
    myArr[count] = Convert.ToInt32(Console.ReadLine());
    count++;
}
Console.WriteLine("Вывод чисел:");
for (i = 0; i < myArr.Length; i++)
{
    Console.WriteLine(myArr[i]);
}