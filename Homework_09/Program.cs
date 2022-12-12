namespace Homework_09;

public static class Homework09
{
    /// <summary>
    /// Отрисовка меню и запуск выбраных функций
    /// </summary>
    public static void Main()
    {
        var menuItems = new[] { "Задача 64", "Задача 66", "Задача 68", "Выход" };
        var selectedIndex = Menu.WorkingMenu(menuItems);
        if (selectedIndex == 0)
            Exercise_64();
        else if (selectedIndex == 1)
            Exercise_66();
        else if (selectedIndex == 2)
            Exercise_68();
        else if (selectedIndex == 3)
        {
            Console.Clear();
            Console.WriteLine("Выбран выход из приложения");
        }
        else
        {
            Console.WriteLine($"Выбрана {menuItems[selectedIndex]}");
        }
    }

    /// <summary>
    /// Задача 64
    /// </summary>
    public static void Exercise_64()
    {
        Console.WriteLine("Задача 64: Задайте значение N. Напишите программу," +
                          " которая выведет все натуральные числа в промежутке от N до 1." +
                          " Выполнить с помощью рекурсии.");

        int[] valueN = Helpers.GetEnteredNumbers("Задайте значение N через пробел или запятую: ", true);
        if (valueN.Length >= 1)
            Helpers.RecursionN(valueN[0]);
        else
            Console.WriteLine("Введено не корректное значение(Пример: 5)");
    }

    /// <summary>
    /// Задача 66
    /// </summary>
    public static void Exercise_66()
    {
        Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, " +
                          "которая найдёт сумму натуральных элементов в промежутке от M до N.");
        int[] valueN = Helpers.GetEnteredNumbers("Задайте значения M и N через пробел или запятую: ", true);
        if (valueN.Length >= 2)
        {
            int result = Helpers.SumBetweenMn(valueN[0], valueN[1]);
            Console.WriteLine($"M = {valueN[0]}; N = {valueN[1]} -> {result}");
        }
        else
            Console.WriteLine("Введено не корректное значение(Пример: 4, 8)");
    }

    /// <summary>
    /// Задача 68
    /// </summary>
    public static void Exercise_68()
    {
        Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. " +
                          "Даны два неотрицательных числа m и n.");
        int[] valueN = Helpers.GetEnteredNumbers("Задайте два неотрицательных числа M и N " +
                                                 "через пробел или запятую: ", true);
        if (valueN.Length >= 2 && valueN[0] > 0 && valueN[1] > 0)
        {
            int result = Helpers.Akkerman(valueN[0], valueN[1]);
            Console.WriteLine($"m = {valueN[0]}, n = {valueN[1]} -> A(m,n) = {result}");
        }
        else
            Console.WriteLine("Введено не корректное значение(Пример: 2, 3)");
    }
}