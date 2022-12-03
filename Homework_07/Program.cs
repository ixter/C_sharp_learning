namespace Homework_07;

public static class Homework07
{
    /// <summary>
    ////Отрисовка меню и запуск выбраных функций
    /// </summary>
    public static void Main()
    {
        var menuItems = new string[] { "Задача 47", "Задача 50", "Задача 52", "Выход" };

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
                        Exercise_47();
                    else if (index == 1)
                        Exercise_50();
                    else if (index == 2)
                        Exercise_52();
                    else if (index == 3)
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
    /// Задача 47
    /// </summary>
    static void Exercise_47()
    {
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9
        Console.WriteLine(
            "Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        var numbers = GetEnteredNumbers("Введите число строк и число колонок : ", true);
        Console.WriteLine();
        if (numbers[0] != 0 && numbers[1] != 0)
        {
            var generatedTable = GenerateDoubleArray(numbers[0], numbers[1]);
            PrintDoubleTable(generatedTable);
        }
        else
        {
            Console.WriteLine("Заданные числа =^_^= ");
        }
    }

    /// <summary>
    ///  Выводим в консоль двумерный массив
    /// </summary>
    /// <param name="generatedTable"></param>
    static void PrintDoubleTable(double[,] generatedTable)
    {
        for (int i = 0; i < generatedTable.GetLength(0); i++)
        {
            for (int j = 0; j < generatedTable.GetLength(1); j++)
            {
                Console.Write($"{String.Format("{0:0.#}", generatedTable[i, j])} ");
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Генерируем массив по параметрам
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <param name="type"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    static double[,] GenerateDoubleArray(int m, int n, bool type = true, int from = -9, int to = 10)
    {
        var tableArray = new double[m, n];
        var rand = new Random();
        double randomizedNumber;
        for (int i = 0; i < tableArray.GetLength(0); i++)
        {
            for (int j = 0; j < tableArray.GetLength(1); j++)
            {
                if (type)
                {
                    randomizedNumber = rand.Next(from, to) +
                                       Math.Round(rand.NextDouble(), 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    randomizedNumber = rand.Next(from, to);
                }

                tableArray[i, j] = randomizedNumber;
            }
        }

        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // tableArray = new double[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

        return tableArray;
    }

    /// <summary>
    /// Задача 50
    /// </summary>
    static void Exercise_50()
    {
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет
        Console.WriteLine(
            "Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве," +
            " и возвращает значение этого элемента или же указание, что такого элемента нет.");
        var rowsCols = GetEnteredNumbers("Введите числа строк и столбцов для генерации массива (пример 5, 9): ", true);
        Console.WriteLine();
        double[,] generatedTable;
        if (rowsCols.Length == 2)
            generatedTable = GenerateDoubleArray(rowsCols[0], rowsCols[1], false);
        else
            generatedTable = GenerateDoubleArray(9, 9, false);
        PrintDoubleTable(generatedTable);
        var enteredNumber = GetEnteredNumbers("Введите число для поиска по массиву :");
        var findElement = FindElement(generatedTable, enteredNumber[0]);
        Console.WriteLine(findElement);
    }

    /// <summary>
    /// Задача 52
    /// </summary>
    static void Exercise_52()
    {
        // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        //
        //     Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
        Console.WriteLine(
            "Задача 52. Задайте двумерный массив из целых чисел. " +
            "Найдите среднее арифметическое элементов в каждом столбце.");
        var rowsCols = GetEnteredNumbers("Введите числа строк и столбцов для генерации массива (пример 5, 9): ", true);
        Console.WriteLine();
        double[,] generatedTable;
        if (rowsCols.Length == 2)
            generatedTable = GenerateDoubleArray(rowsCols[0], rowsCols[1], false, from: 1, to: 10);
        else
            generatedTable = GenerateDoubleArray(9, 9, false, from: 1, to: 10);
        PrintDoubleTable(generatedTable);
        var average = GetArrayAverage(generatedTable);
        Console.WriteLine();
        Console.Write("Среднее арифметическое элементов в каждом столбце -> ");
        PrintArray(average);
    }

    /// <summary>
    ///  Печатаем полученный массив типа double
    /// </summary>
    /// <param name="array"></param>
    static void PrintArray(double[] array)
    {
        foreach (var item in array)
        {
            Console.Write($"{String.Format("{0:0.#}", item)} ");
        }
    }

    /// <summary>
    /// Получаем из массива среднее арифметическое
    /// </summary>
    /// <param name="arrayTable"></param>
    /// <returns></returns>
    static double[] GetArrayAverage(double[,] arrayTable)
    {
        double[] findedNumber = new double[arrayTable.GetLength(0)];
        for (int i = 0; i < arrayTable.GetLength(0); i++)
        {
            double sumElements = 0;
            for (int j = 0; j < arrayTable.GetLength(1); j++)
            {
                sumElements += arrayTable[i, j];
            }

            findedNumber[i] = sumElements / arrayTable.GetLength(1);
        }

        return findedNumber;
    }

    /// <summary>
    /// Поиск элемента и его повторений
    /// </summary>
    /// <param name="arrayTable"></param>
    /// <param name="searched"></param>
    /// <returns></returns>
    static string FindElement(double[,] arrayTable, double searched = 0)
    {
        double findedNumber = 0;
        double findedCount = 0;
        for (int i = 0; i < arrayTable.GetLength(0); i++)
        {
            for (int j = 0; j < arrayTable.GetLength(1); j++)
            {
                // if (Math.Abs(arrayTable[i, j]) == Math.Abs(searched))
                if (arrayTable[i, j] == searched)
                {
                    findedNumber = arrayTable[i, j];
                    findedCount++;
                }
            }
        }

        return findedNumber != 0
            ? $"Найденное число: {findedNumber} -> найдено таких чисел {findedCount}"
            : $"{searched} -> такого числа в массиве нет";
    }

    /// <summary>
    /// Функция получает текст и просит ввести данные в строку через запятую или пробел
    /// </summary>
    /// <param name="outputText"></param>
    /// <returns></returns>
    static int[] GetEnteredNumbers(string outputText = "", bool inline = false)
    {
        var arrayInts = Array.Empty<int>();
        if (inline)
            Console.Write(outputText);
        else
            Console.WriteLine(outputText);

        char[] separators = { ' ', ',' };
        var arrayOfEnteredText = Console.ReadLine()
            ?.Split(separators,
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (arrayOfEnteredText != null)
            arrayInts = Array.ConvertAll(arrayOfEnteredText, s => int.Parse(s));

        return arrayInts;
    }
}