// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// int first;
// int second;
// Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
// Console.Write("Введите число 1: ");
// first = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// second = Convert.ToInt32(Console.ReadLine());
// Console.Write("a = " + first + " b = " + second + " -> max = " + Math.Max(first,second));


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int a;
// int b;
// int c;
// string? i;
// string[]? arrZap;
// string[]? arrSpace;
// Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
// Console.WriteLine("Введите числа в формате 22 3 9");
// i = Console.ReadLine();
// arrZap = i?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
// arrSpace = i?.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
// if (arrZap != null && arrZap.Length >= 3)
// {
//      a = Convert.ToInt32(arrZap[0]);
//      b = Convert.ToInt32(arrZap[1]);
//      c = Convert.ToInt32(arrZap[2]);
//      Console.Write("Вывод максимального числа: " + Math.Max(a, Math.Max(b, c)));
// }
// else if (arrSpace != null && arrSpace.Length >= 3)
// {
//      a = Convert.ToInt32(arrSpace[0]);
//      b = Convert.ToInt32(arrSpace[1]);
//      c = Convert.ToInt32(arrSpace[2]);
//      Console.Write("Вывод максимального числа: " + Math.Max(a, Math.Max(b, c)));
// }
// else
// {
//      Console.WriteLine("Ошибка");
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
// 4 -> да
// -3 -> нет
// 7 -> нет

// int number;
// Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
// Console.WriteLine("Введите число : ");
// number = Convert.ToInt32(Console.Read());
// if (number % 2 == 0)
// {
//     Console.WriteLine("Четное");
// }
// else
// {
//     Console.WriteLine("Нечетное");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// int? number;
// int i = 1;
// Console.WriteLine(
//     "Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
// Console.Write("Введите число: ");
// number = Convert.ToInt32(Console.ReadLine());
// if (number != null)
// {
//     while (i <= number)
//     {
//         if (i % 2 == 0)
//         {
//             Console.WriteLine(i);
//         }
//         i++;
//     }
// }
// else
// {
//     Console.WriteLine("Ошибка");
// }


// Задачи с урока до просмотра семинара.

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// int first;
// int second_orig;
// double second;
// int sqrt;
// Console.WriteLine("Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.");
// Console.Write("Введите число из которого будет вычислен корень: ");
// first = Convert.ToInt32(Console.ReadLine());
// sqrt = (int)Math.Sqrt(first);
// Console.Write("Введите число которое будет проверено является ли первое число корнем второго: ");
// second_orig = Convert.ToInt16(Console.ReadLine());
// second = Convert.ToDouble(second_orig.ToString("##;##"));
// if (sqrt == second)
// {
//     Console.WriteLine("Ведённое число 1: " + first);
//     Console.WriteLine("Корень числа 1: " + sqrt);
//     Console.WriteLine("Число 2: " + second_orig);
//     Console.WriteLine("Корень числа 1 равен числу 2");    
// }
// else
// {
//     Console.WriteLine("Ведённое число 1: " + first);
//     Console.WriteLine("Корень числа 1: " + sqrt);
//     Console.WriteLine("Число 2: " + second_orig);
//     Console.WriteLine("Корень числа 1 не равен числу 2");
// }


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// int week;
// Console.WriteLine("Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.");
// Console.Write("Введите число от 1 до 7: ");
// week = Convert.ToInt16(Console.ReadLine());
// if (week <= 7)
// {
//     switch(week)
//     {
//         case 1:
//             Console.WriteLine(week+" -> Понедельник");
//             break;
//         case 2:
//             Console.WriteLine(week+" -> Вторник");
//             break;
//         case 3:
//             Console.WriteLine(week+" -> Среда");
//             break;
//         case 4:
//             Console.WriteLine(week+" -> Четверг");
//             break;
//         case 5:
//             Console.WriteLine(week+" -> Пятница");
//             break;
//         case 6:
//             Console.WriteLine(week+" -> Суббота");
//             break;
//         case 7:
//             Console.WriteLine(week+" -> Воскресенье");
//             break;
//     }    
// }
// else
// {
//     Console.WriteLine("Неверно введено число.");
// }

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// int number;
// int count;
// Console.WriteLine("Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.");
// Console.Write("Введите число: ");
// number = Convert.ToInt16(Console.ReadLine());
// count = number * 2;
// // Console.WriteLine(count);
// if (number > 0)
// {
//     count++;
//     number = -number;
//     while (count > 0)
//     {
//         Console.WriteLine(number++);
//         count--;
//     }
// }
// else
// {
//     count--;
//     while (count < 0)
//     {
//         Console.WriteLine(number++);
//         count++;
//     }
// }


// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// string? number;
// Console.WriteLine("Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");
// Console.Write("Введите трехзначное число: ");
// number = Console.ReadLine();
// if (number != null && number.Length == 3)
// {
//     Console.WriteLine(number + " -> " + number[2]);    
// }
// else
// {
//     Console.WriteLine("Неверно указано число");
// }