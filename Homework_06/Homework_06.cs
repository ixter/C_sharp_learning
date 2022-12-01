namespace Homework_06;

public static class Homework06
{
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

    static void Exercise_41()
    {
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223-> 3
        Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. " +
                          "Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        var enteredNumbers = GetEnteredNumbers();
        Console.WriteLine($"{String.Join(", ", enteredNumbers)} -> {String.Join(", ", CheckPositive(enteredNumbers))}");
    }

    static void Exercise_43()
    {
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
        Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых," +
                          " заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
    }

    static int[] GetEnteredNumbers()
    {
        var arrayInts = Array.Empty<int>();
        Console.WriteLine("Введите числа через пробел или запятую :");
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