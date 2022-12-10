namespace Homework_08;

public static class Homework08
{
    /// <summary>
    ////Отрисовка меню и запуск выбраных функций
    /// </summary>
    public static void Main()
    {
        var menuItems = new[] { "Задача 54", "Задача 56", "Задача 58", "Задача 60", "Задача 62", "Выход" };
        var selectedIndex = Menu.WorkingMenu(menuItems);
        if (selectedIndex == 0)
            Exercise_54();
        else if (selectedIndex == 1)
            Exercise_56();
        else if (selectedIndex == 2)
            Exercise_58();
        else if (selectedIndex == 3)
            Exercise_60();
        else if (selectedIndex == 4)
            Exercise_62();
        else if (selectedIndex == 5)
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
    /// Задача 54
    /// </summary>
    public static void Exercise_54()
    {
        Console.WriteLine(
            "Задача 54: Задайте двумерный массив. Напишите программу, " +
            "которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        var numbersArray = Helpers.GetEnteredNumbers("Укажите 1 число для строк," +
                                                     " второе количество столбцов: ", true);
        if (numbersArray.Length >= 2)
        {
            var setArray = Helpers.GenerateDoubleArray(numbersArray[0],numbersArray[1], 1);
            Helpers.PrintTable(setArray);
            Console.WriteLine();
            // 2 варианта сортировки
            setArray = Helpers.OrderArray(setArray);
            // setArray = Helpers.OrderArrayLines(setArray);
            Helpers.PrintTable(setArray);
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
    
    /// <summary>
    /// Задача 56
    /// </summary>
    public static void Exercise_56()
    {
        Console.WriteLine(
            "Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        var numbersArray = Helpers.GetEnteredNumbers("Укажите 1 число для строк," +
                                                     " второе количество столбцов: ", true);
        if (numbersArray.Length >= 2)
        {
            var setArray = Helpers.GenerateDoubleArray(numbersArray[0],numbersArray[1], 1);
            Helpers.PrintTable(setArray);
            Console.WriteLine();
            var sum = Helpers.SumRows(setArray);
            Console.WriteLine($"Строка {sum.Item1}, содержит наименьшую сумму элементов: {sum.Item2}");
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
    
    /// <summary>
    /// Задача 58
    /// </summary>
    public static void Exercise_58()
    {
        Console.WriteLine(
            "Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        var numbersArray = Helpers.GetEnteredNumbers("Укажите 1 число для строк," +
                                                     " второе количество столбцов: ", true);
        if (numbersArray.Length >= 2)
        {
            var setArray1 = Helpers.GenerateDoubleArray(numbersArray[0],numbersArray[1], 1);
            var setArray2 = Helpers.GenerateDoubleArray(numbersArray[0],numbersArray[1], 1);
            Helpers.PrintTable(setArray1);
            Console.WriteLine("Матрица 1");
            Helpers.PrintTable(setArray2);
            Console.WriteLine("Матрица 2");
            var sum = Helpers.MultipleMatrix(setArray1,setArray2);
            Helpers.PrintTable(sum);
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
        
    }
    
    /// <summary>
    /// Задача 60
    /// </summary>
    public static void Exercise_60()
    {
        Console.WriteLine(
            "Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,");
        var numbersArray = Helpers.GetEnteredNumbers("Укажите 3 числа для генерации трёхмерного массива: ", true);
        if (numbersArray.Length >= 3)
        {
            var setArray = Helpers.GenerateTripleArray(numbersArray);
            Helpers.PrintTripleTable(setArray);
            Helpers.PrintFormatedTripleTable(setArray);
        }
    }
    
    /// <summary>
    /// Задача 62
    /// </summary>
    public static void Exercise_62()
    {
        Console.WriteLine(
            "Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
        var numbersArray = Helpers.GetEnteredNumbers("Укажите 1 число для строк от 4," +
                                                     " второе количество столбцов от 4: ", true);
        if (numbersArray.Length >= 2 && numbersArray[0] >= 4 && numbersArray[1] >= 4)
        {
            var spiralArray = Helpers.GenerateArraySpiral(numbersArray);
            Helpers.PrintTableString(spiralArray);
        }
    }
    
}