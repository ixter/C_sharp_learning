namespace Homework_07;

public class Helpers
{
    /// <summary>
    /// Функция получает текст и просит ввести данные в строку через запятую или пробел
    /// </summary>
    /// <param name="outputText"></param>
    /// <returns></returns>
    public static int[] GetEnteredNumbers(string outputText = "", bool inline = false)
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
    
    /// <summary>
    ///  Выводим в консоль двумерный массив
    /// </summary>
    /// <param name="generatedTable"></param>
    public static void PrintDoubleTable(double[,] generatedTable)
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
    public static double[,] GenerateDoubleArray(int m, int n, bool type = true, int from = -9, int to = 10)
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
    /// Получаем из массива среднее арифметическое
    /// </summary>
    /// <param name="arrayTable"></param>
    /// <returns></returns>
    public static double[] GetArrayAverage(double[,] arrayTable)
    {
        double[] findedNumber = new double[arrayTable.GetLength(0)];
        for (int i = 0; i < arrayTable.GetLength(1); i++)
        {
            double sumElements = 0;
            for (int j = 0; j < arrayTable.GetLength(0); j++)
            {
                sumElements += arrayTable[j, i];
            }

            findedNumber[i] = sumElements / arrayTable.GetLength(0);
        }

        return findedNumber;
    }

    /// <summary>
    /// Поиск элемента и его повторений
    /// </summary>
    /// <param name="arrayTable"></param>
    /// <param name="searched"></param>
    /// <returns></returns>
    public static string FindElement(double[,] arrayTable, double searched = 0)
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
    ///  Печатаем полученный массив типа double
    /// </summary>
    /// <param name="array"></param>
    public static void PrintArrayDouble(double[] array)
    {
        foreach (var item in array)
        {
            Console.Write($"{String.Format("{0:0.#}", item)} ");
        }
    }
}