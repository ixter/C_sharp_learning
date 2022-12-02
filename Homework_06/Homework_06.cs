namespace Homework_06;

public static class Homework06
{
    /// <summary>
    ////Отрисовка меню и запуск выбраных функций
    /// </summary>
    public static void Main()
    {
        var menuItems = new string[] { "Задача 41", "Задача 43", "Выход" };

        Console.WriteLine("Меню");
        Console.WriteLine();

        var row = Console.CursorTop;
        var col = Console.CursorLeft;
        var index = 0;
        while (true)
        {
            // для разообразия выкинул в отдельный класс
            Menu.DrawMenu(menuItems, row, col, index);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (index < menuItems.Length - 1)
                        index++;
                    Console.Clear();
                    break;
                case ConsoleKey.UpArrow:
                    if (index > 0)
                        index--;
                    Console.Clear();
                    break;
                case ConsoleKey.Enter:
                    if (index == 0)
                        Exercise_41();
                    else if (index == 1)
                        Exercise_43();
                    else if (index == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Выбран выход из приложения");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Выбрана {menuItems[index]}");
                        
                    }

                    break;
            }
        }
    }
    
/// <summary>
/// Задача 41
/// </summary>
    static void Exercise_41()
    {
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223-> 3
        Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. " +
                          "Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        var enteredNumbers = GetEnteredNumbers("Введите числа через пробел или запятую :");
        Console.WriteLine($"{String.Join(", ", enteredNumbers)} -> {String.Join(", ", CheckPositive(enteredNumbers))}");
    }
/// <summary>
/// Задача 43
/// </summary>
    static void Exercise_43()
    {
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
        Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых," +
                          " заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        var enteredNumbers = GetEnteredNumbers("Введите b1,k1,b2,k2: через пробел или запятую :");
        var points = GetIntersectionPoints(enteredNumbers);
        if (points.Item1 != 0 && points.Item2 != 0)
            Console.WriteLine($"{points}");
    }

/// <summary>
///  Получение точек пересечения двух прямых
/// </summary>
/// <param name="arrPoints"></param>
/// <returns></returns>
    static (double, double) GetIntersectionPoints(int[] arrPoints)
    {
        double b1, k1, b2, k2;
        double x = 0, y = 0;
        if (arrPoints.Length == 4)
        {
            b1 = arrPoints[0];
            k1 = arrPoints[1];
            b2 = arrPoints[2];
            k2 = arrPoints[3];
            if ((k1 == k2) && (b1 == b2))
                Console.WriteLine("Прямые совпадают");
            else if (k1==k2)
                Console.WriteLine("Прямые параллельны");
            else
            {
                x=(b2-b1)/(k1-k2);
                y=(k1*(b2-b1))/(k1-k2)+b1;
            }
        }

        return (x, y);
    }

/// <summary>
/// Функция получает текст и просит ввести данные в строку через запятую или пробел
/// </summary>
/// <param name="outputText"></param>
/// <returns></returns>
    static int[] GetEnteredNumbers(string outputText = "")
    {
        var arrayInts = Array.Empty<int>();
        Console.WriteLine(outputText);
        char[] separators = { ' ', ',' };
        var arrayOfEnteredText = Console.ReadLine()
            ?.Split(separators,
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (arrayOfEnteredText != null)
        {
            arrayInts = Array.ConvertAll(arrayOfEnteredText, s => int.Parse(s));
        }
        return arrayInts;
    }

/// <summary>
/// Чекаем положительные числа
/// </summary>
/// <param name="array"></param>
/// <returns></returns>
    static int CheckPositive(int[] array)
    {
        var count = 0;
        foreach (var item in array)
        {
            if (item > 0)
                count++;
        }
        return count;
    }
}