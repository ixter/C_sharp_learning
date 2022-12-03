namespace Homework_07;

public static class Homework07
{
    /// <summary>
    ////Отрисовка меню и запуск выбраных функций
    /// </summary>
    public static void Main()
    {
        var menuItems = new[] { "Задача 47", "Задача 50", "Задача 52", "Выход" };
        var selectedIndex = Menu.WorkingMenu(menuItems);
        if (selectedIndex == 0)
            Exercise_47();
        else if (selectedIndex == 1)
            Exercise_50();
        else if (selectedIndex == 2)
            Exercise_52();
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
    /// Задача 47
    /// </summary>
    public static void Exercise_47()
    {
        Console.WriteLine(
            "Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        var numbers = Helpers.GetEnteredNumbers("Введите число строк и число колонок : ", true);
        Console.WriteLine();
        if (numbers[0] != 0 && numbers[1] != 0)
            Helpers.PrintDoubleTable(Helpers.GenerateDoubleArray(numbers[0], numbers[1]));
        else
            Console.WriteLine("Заданные числа =^_^= ");
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9
    }

    /// <summary>
    /// Задача 50
    /// </summary>
    public static void Exercise_50()
    {
        Console.WriteLine(
            "Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве," +
            " и возвращает значение этого элемента или же указание, что такого элемента нет.");
        var rowsCols = Helpers.GetEnteredNumbers("Введите числа строк и столбцов " +
                                                 "для генерации массива (пример 5, 9): ", true);
        Console.WriteLine();
        double[,] generatedTable;
        if (rowsCols.Length == 2)
            generatedTable = Helpers.GenerateDoubleArray(rowsCols[0], rowsCols[1], false);
        else
            generatedTable = Helpers.GenerateDoubleArray(9, 9, false);
        Helpers.PrintDoubleTable(generatedTable);
        var enteredNumber = Helpers.GetEnteredNumbers("Введите число для поиска по массиву :");
        var findedElement = Helpers.FindElement(generatedTable, enteredNumber[0]);
        Console.WriteLine(findedElement);
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет
    }

    /// <summary>
    /// Задача 52
    /// </summary>
    public static void Exercise_52()
    {
        Console.WriteLine(
            "Задача 52. Задайте двумерный массив из целых чисел. " +
            "Найдите среднее арифметическое элементов в каждом столбце.");
        var rowsCols = Helpers.GetEnteredNumbers("Введите числа строк и столбцов для " +
                                                 "генерации массива (пример 5, 9): ", true);
        Console.WriteLine();
        double[,] generatedTable;
        if (rowsCols.Length == 2)
            generatedTable = Helpers.GenerateDoubleArray(rowsCols[0], rowsCols[1], false, from: 1, to: 10);
        else
            generatedTable = Helpers.GenerateDoubleArray(9, 9, false, from: 1, to: 10);
        Helpers.PrintDoubleTable(generatedTable);
        var average = Helpers.GetArrayAverage(generatedTable);
        Console.WriteLine();
        Console.Write("Среднее арифметическое элементов в каждом столбце -> ");
        Helpers.PrintArrayDouble(average);
        //     Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    }
}