namespace Homework_08;

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
        try
        {
            char[] separators = { ' ', ',' };
            var arrayOfEnteredText = Console.ReadLine()
                ?.Split(separators,
                    StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (arrayOfEnteredText != null)
                arrayInts = Array.ConvertAll(arrayOfEnteredText, s => int.Parse(s));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return arrayInts;
    }

    /// <summary>
    ///  Выводим в консоль двумерный массив
    /// </summary>
    /// <param name="generatedTable"></param>
    public static void PrintTable(int[,] generatedTable)
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
    ///  Выводим в консоль трехмерный массив
    /// </summary>
    /// <param name="table"></param>
    public static void PrintTripleTable(int[,,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                for (int k = 0; k < table.GetLength(2); k++)
                {
                    Console.Write($"{String.Format("{0:0.#}", table[i, j, k])} ");
                }
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    ///  Выводим в консоль трехмерный массив
    /// </summary>
    /// <param name="table"></param>
    public static void PrintFormatedTripleTable(int[,,] table)
    {
        for (int z = 0; z < table.GetLength(2); z++)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j, z]} ({i}, {j}, {z}) ");
                }

                Console.WriteLine();
            }
        }
        // 66(0,0,0) 25(0,1,0)
        // 34(1,0,0) 41(1,1,0)
        // ----------------------
        // 27(0,0,1) 90(0,1,1)
        // 26(1,0,1) 55(1,1,1)
    }

    /// <summary>
    /// Генерируем массив по параметрам
    /// </summary>
    /// <param name="rows"></param>
    /// <param name="columns"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public static int[,] GenerateDoubleArray(int rows, int columns, int from = -9, int to = 10)
    {
        var tableArray = new int[rows, columns];
        var rand = new Random();
        for (int i = 0; i < tableArray.GetLength(0); i++)
        {
            for (int j = 0; j < tableArray.GetLength(1); j++)
            {
                tableArray[i, j] = rand.Next(from, to);
            }
        }

        return tableArray;
    }

    /// <summary>
    /// Генерируем массив по параметрам
    /// </summary>
    /// <param name="rows"></param>
    /// <param name="columns"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public static int[,,] GenerateTripleArray(int[] arrayNumbers, int from = 9, int to = 100)
    {
        var tableArray = new int[arrayNumbers[0], arrayNumbers[1], arrayNumbers[2]];
        var rand = new Random();
        for (int i = 0; i < tableArray.GetLength(0); i++)
        {
            for (int j = 0; j < tableArray.GetLength(1); j++)
            {
                for (int k = 0; k < tableArray.GetLength(2); k++)
                {
                    tableArray[i, j, k] = rand.Next(from, to);
                }
            }
        }

        return tableArray;
    }

    public static int[,] OrderArray(int[,] tableArray)
    {
        for (int i = 0; i < tableArray.GetLength(0); i++)
        {
            var tempRow = GetArray(tableArray, i);
            Array.Sort(tempRow);
            Array.Reverse(tempRow);
            for (int j = 0; j < tableArray.GetLength(1); j++)
            {
                tableArray[i, j] = tempRow[j];
            }
        }

        return tableArray;
    }

    public static (int, int) SumRows(int[,] tableArray)
    {
        var tempRow = new int[tableArray.GetLength(0)];
        var minRow = 0;
        var minNumber = 9999;
        for (int i = 0; i < tableArray.GetLength(0); i++)
        {
            tempRow[i] = GetArray(tableArray, i).Sum();
            if (minNumber > tempRow[i])
            {
                minRow = i + 1;
                minNumber = tempRow[i];
            }
        }

        return (minRow, minNumber);
    }

    public static int[,] OrderArrayLines(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        (array[i, k + 1], array[i, k]) = (array[i, k], array[i, k + 1]);
                    }
                }
            }
        }

        return array;
    }

    public static int[] GetArray(int[,] tableArray, int i)
    {
        int[] tempRow = new int[tableArray.GetLength(1)];
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            tempRow[j] = tableArray[i, j];
        }

        return tempRow;
    }

    public static int[,] MultipleMatrix(int[,] tableArray1, int[,] tableArray2)
    {
        var tableOneRowLength = tableArray1.GetLength(0);
        var tableOneColLength = tableArray1.GetLength(1);
        int[,] multipleArray = new int[tableOneRowLength, tableOneColLength];
        for (int i = 0; i < tableOneRowLength; i++)
        {
            for (int j = 0; j < tableOneColLength; j++)
            {
                int sum = 0;
                for (int k = 0; k < tableOneColLength; k++)
                {
                    //a11*b11 + a12 * b21
                    // 2*3    +   4*3
                    sum += tableArray1[i, k] * tableArray2[k, j];
                }

                multipleArray[i, j] = sum;
            }
        }

        // Например, даны 2 матрицы:
        // 2 4 | 3 4
        // 3 2 | 3 3
        // Результирующая матрица будет:
        // 18 20
        // 15 18
        return multipleArray;
    }

    public static string[,] GenerateArraySpiral()
    {
        var initialArray = new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16" };
        string[,] spiralArray = new string [4, 4];
        int x = 0, y = 0, xMax = 3, yMax = 3, indexInitialArray = 0;
        string direction = "right";
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (spiralArray[y, x] == null)
            {
                spiralArray[y, x] = initialArray[indexInitialArray];
                indexInitialArray++;
                (direction, x, y) = CheckAction(spiralArray,direction,x,y,xMax,yMax);
            }
        }

        return spiralArray;
        // Например, на выходе получается вот такой массив:
        //   00 10 20 30 !
        //!! 01 02 03 04 30 
        //01 12 13 14 05 31
        //02 11 16 15 06 32
        //03 10 09 08 07 33
        // ! 03 13 23 33 !     
    }

    static (string,int,int) CheckAction(string[,] spiralArray,string direction,int x, int y,int xMax,int yMax)
    {
        if (direction == "right")
        {
            if (spiralArray[y, x + 1] == null)
                x += 1;
            else
            {
                direction = "down";
                y += 1;
            }
            if (x == xMax)
                direction = "down";
        }
        else if (direction == "down")
        {
            if (spiralArray[y + 1, x] == null)
                y += 1;
            else
            {
                direction = "left";
                x -= 1;
            }
            if (y == yMax)
                direction = "left";
        }
        else if (direction == "left")
        {
            if (spiralArray[y, x - 1] == null)
                x -= 1;
            else
            {
                direction = "up";
                y -= 1;
            }
            if (x == 0)
                direction = "up";
        }
        else if (direction == "up")
        {
            if (spiralArray[y - 1, x] == null)
                y -= 1;
            else
            {
                direction = "right";
                x += 1;
            }
        }
        return (direction,x,y);
    }
    
    /// <summary>
    ///  Выводим в консоль двумерный массив
    /// </summary>
    /// <param name="generatedTable"></param>
    public static void PrintTableString(string[,] generatedTable)
    {
        for (int i = 0; i < generatedTable.GetLength(0); i++)
        {
            for (int j = 0; j < generatedTable.GetLength(1); j++)
            {
                Console.Write($"{generatedTable[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}