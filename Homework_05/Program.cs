using System;

public class Homework_05
{
    public static void Main()
    {
        string[] menuItems = new string[] { "Задача 34", "Задача 36", "Задача 38", "Выход" };

        Console.WriteLine("Меню");
        Console.WriteLine();

        int row = Console.CursorTop;
        int col = Console.CursorLeft;
        int index = 0;
        while (true)
        {
            DrawMenu(menuItems, row, col, index);
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
                    switch (index)
                    {
                        case 0:
                            Exercise_34();
                            break;
                        case 1:
                            Exercise_36();
                            break;
                        case 2:
                            Exercise_38();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Выбран выход из приложения");
                            return;
                        default:
                            Console.WriteLine($"Выбрана {menuItems[index]}");
                            break;
                    }
                    break;
            }
        }
    }

    static void Exercise_38()
    {
        Console.WriteLine("Задача 38: Задайте массив вещественных чисел. " +
                          "Найдите разницу между максимальным и минимальным элементов массива.");
        var arrayNumbers = generateArrayDoubles(Convert.ToInt32(Console.ReadLine()), -99, 100);
        WriteDouble(arrayNumbers);
        Console.Write(" -> " + (Math.Abs(arrayNumbers.Max()) - Math.Abs(arrayNumbers.Min())));
    }

    static void Exercise_36()
    {
        Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. " +
                          "Найдите сумму элементов, стоящих на нечётных позициях.");
//     [3, 7, 23, 12] -> 19
//     [-4, -6, 89, 6] -> 0
        Console.WriteLine("Укажите число элементов для генерации массива: ");
        try
        {
            var arrayNumbers = GenerateArray(Convert.ToInt32(Console.ReadLine()), -99, 100);
            var not_even = CheckEven(arrayNumbers, "not_even_elem");
            Write(arrayNumbers);
            Console.Write(" -> " + not_even.Sum());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    static void Exercise_34()
    {
        Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами." +
                          " Напишите программу, которая покажет количество чётных чисел в массиве.");
        //     [345, 897, 568, 234] -> 2
        Console.WriteLine("Укажите число элементов для генерации трёхзначных массива: ");
        try
        {
            var arrayNumbers = GenerateArray(Convert.ToInt32(Console.ReadLine()), 99);
            var even = CheckEven(arrayNumbers, "even");
            Write(arrayNumbers);
            Console.Write(" -> " + even.Length);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    static int[] CheckEven(int[] arr, string type = "all")
    {
        int[] tempArr = Array.Empty<int>();
        if (arr != null)
        {
            // tempArr = new int [arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && type == "even")
                {
                    Array.Resize(ref tempArr, tempArr.Length + 1);
                    tempArr[tempArr.Length - 1] = arr[i];
                }
                else if (i % 2 != 0 && type == "not_even_elem")
                {
                    Array.Resize(ref tempArr, tempArr.Length + 1);
                    tempArr[tempArr.Length - 1] = arr[i];
                }
                else if (type == "all")
                {
                    Array.Resize(ref tempArr, tempArr.Length + 1);
                    tempArr[tempArr.Length - 1] = arr[i];
                }
            }
        }

        return tempArr;
    }

    static int[] GenerateArray(int num = 5, int from = -999, int to = 1000)
    {
        var arr = new int[num];
            for (var i = 0; i < num; i++)
            {
                arr[i] = new Random().Next(from, to);
            }
            return arr;
    } 
    static double[] generateArrayDoubles(int num = 5, int from = -999, int to = 1000)
    {
        var arr = new double[num];
            for (var i = 0; i < num; i++)
            {
                arr[i] = new Random().Next(from, to) + new Random().NextDouble();
            }
            return arr;
    }

    static void Write(int[] array, bool type = true)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var start = i == 0 ? "[" : "";
            var zap = i == array.Length - 1 ? "]" : ", ";
            if (type)
                Console.Write($"{start}{array[i]}{zap}");
            else
                Console.WriteLine($"{start}{array[i]}{zap}");
        }
    }
    static void WriteDouble(double[] array, bool type = true)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var start = i == 0 ? "[" : "";
            var zap = i == array.Length - 1 ? "]" : ", ";
            if (type)
                Console.Write($"{start}{array[i]}{zap}");
            else
                Console.WriteLine($"{start}{array[i]}{zap}");
        }
    }

    private static void DrawMenu(string[] items, int row, int col, int index)
    {
        Console.SetCursorPosition(col, row);
        for (int i = 0; i < items.Length; i++)
        {
            if (i == index)
            {
                Console.BackgroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            Console.WriteLine(items[i]);
            Console.ResetColor();
        }

        Console.WriteLine();
    }
}