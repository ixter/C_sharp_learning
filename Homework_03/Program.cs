// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первое решение задачи

// string? text;
// bool palindrome = true;
// int n;
// Console.WriteLine("Введите пятизначное число: ");
// text = Console.ReadLine();
// if (text != null)
// {
//     n = text.Length;
//     for (int i = 0; i < n / 2; i++)
//     {
//         if (text[i] != text[n - 1 - i])
//             palindrome = false;
//     }
//     if (palindrome)
//     {
//         Console.WriteLine(text + "палиндром");
//     }
//     else
//     {
//         Console.WriteLine(text + "Не палиндром");
//     }
// }


// Второе решение задачи

// Console.Write("Введите пятизначное число: ");
// int digits, first, last, second, fourth;
// digits = Convert.ToInt32(Console.ReadLine());
// first = digits / 10000;
// last = digits % 10;
// second = (digits / 1000) % 10;
// fourth = (digits % 100) / 10;
//
// if (digits > 9999 && digits <= 99999)
// {
//     if (first == last && second == fourth)
//     {
//         Console.WriteLine($"{digits} -> является палиндромом {first}{second} {fourth}{last}");
//     }
//     else
//     {
//         Console.WriteLine($"{digits} -> не является палиндромом");
//     }    
// }
// else
// {
//     Console.WriteLine("вы ввели не правильное число");
// }


//--------------------------------------------------------------------------------------------------------------------//


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1, x2, y1, y2, z1, z2;
// double distance;
// Console.WriteLine("Введите координаты точки A: ");
// Console.Write("x1: ");
// x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y1: ");
// y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z1: ");
// z1 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Введите координаты точки B: ");
// Console.Write("x2: ");
// x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y2: ");
// y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z2: ");
// z2 = Convert.ToInt32(Console.ReadLine());
//
// distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) ->");
// Console.WriteLine("{0: 0.00}", distance);

//-------------------------------------------------------------------------------------------------------------------//

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// var num = Convert.ToInt32(Console.ReadLine());
// string start_text = num + " -> ";
// string zap;
// for (int i = 1; i <= num; i++)
// {
//     zap = i == num ? "" : ", "; //тернарка
//     start_text = start_text.Insert(start_text.Length,Convert.ToString(Math.Pow(i, 3)) + zap); 
// }
// Console.WriteLine(start_text);