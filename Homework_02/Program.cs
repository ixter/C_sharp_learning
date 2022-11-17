// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// первое решение строковое 10 задачи
// string? input_text;
//
// Console.WriteLine("Введите трёхзначное число");
// input_text = Console.ReadLine();
// if (input_text != null && input_text.Length == 3)
// {
//     Console.WriteLine(input_text+" -> " + input_text[1]);
// }
// else
// {
//     Console.WriteLine("неверно введено число");
// }

//второе решение 10 задачи математическое

// string? input_text;
// int input_number;
// int number;
//     
// Console.WriteLine("Введите трёхзначное число");
// input_text = Console.ReadLine();
// if (input_text != null && input_text.Length == 3)
// {
//     input_number = Convert.ToInt32(input_text);    
//     number = (int)(input_number / 10); // остаются первые две цыфры трёхзначного числа
//     number = number % 10;   // убираем остаток и остаётся центральная цифра
//
//     Console.WriteLine($"{input_number} -> {number}");
// }
// else
// {
//     Console.WriteLine("неверно введено число");
// }

// краткое решение 10 задачи
// Console.WriteLine("Введите трёхзначное число :");
// string? textVal = Console.ReadLine();
// Console.WriteLine(textVal != null && textVal.Length == 3 ? $"{Convert.ToInt32(textVal) / 10 % 10}" : "Не верное число");


//------------------------------------------------------------------------------------------------------------------------------------------------------//

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// string? inputText;
// //вводим число
// Console.Write("Введите число: ");
// //создаём переменную inputText которой присваиваем значение Console.Write
// inputText = Console.ReadLine();
// //создаём условие:  если переменная inputText.Length количество символов больше 2 по массиву строки,то
// if (inputText.Length > 2)
// { //то консоль выводит на экран текст "третья цифра -> и обращается ко второму элементу массива и пишет его значение"
//     Console.WriteLine("третья цифра -> " + inputText[2]);
// }
// else
// { //иначе если значение переменной inputText.Length меньше двух, то коносль выводит текст "третьей цифры нет"
//     Console.WriteLine("-> третьей цифры нет");
// }

// 13 задача математическое решение

// double input_number, number;
//
// Console.WriteLine("Введите трёхзначное число");
// input_number = Convert.ToDouble(Console.ReadLine());
// if (input_number < 1000 && input_number > 99)
// {
//     number = input_number / 10;
//     number = number - (int)number;
//     number = (int)(number * 10);
//     Console.WriteLine($"{input_number} -> {number}");
// }
// else
// {
//     Console.WriteLine("неверно введено число");
// }


// другое рещение 13 задачи

// int? number;
// Console.WriteLine("Введите число :");
// number = Convert.ToInt32(Console.ReadLine());
// if (number > 99)
// {
//     for (bool i = false; i == false;)
//     {
//         if (number < 999)
//         {
//             i = true;
//             Console.WriteLine("третья цифра ->" + number % 10);
//         }
//         else
//         {
//             number = number / 10; 
//         }
//     }
// }
// else if (number > 9 && number < 100)
// {
//     Console.WriteLine(number + " -> третьей цифры нет");
// }
// else
// {
//     Console.WriteLine("Чтот не так");
// }


//----------------------------------------------------------------------------------------------------------------------//

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введи цифру, обозначающую день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
//
// if (day == 6 || day == 7)
// {
//     Console.WriteLine("выходной");
// }
// else if (day < 1 || day > 7)
// {
//     Console.WriteLine("не относится ко дню недели");
// }
// else Console.WriteLine("не выходной");


// получение текущего дня недели
// int week = Convert.ToInt32(DateTime.Now.DayOfWeek);
// string week_str = DateTime.Now.DayOfWeek.ToString();
//
// if (week == 6 || week == 7)
// {
//     Console.WriteLine(week_str + " -> Ураа выходной! Пора за пивком");
// }
// else if (week < 1 || week > 7)
// {
//     Console.WriteLine(week_str + " -> не относится ко дню недели");
// }
// else Console.WriteLine(week_str + " -> не выходной");