namespace Homework_09;

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
    /// Вывод всех натуральных чисел в промежутке от N до 1
    /// </summary>
    /// <param name="num"></param>
    /// <param name="count"></param>
    public static void RecursionN(int num, int count = 1)
    {
        if (count == 1)
            Console.Write($"N = {num} -> ");
        if (num != 0)
        {
            RecursionN(num - 1, count + 1);
            Console.Write($"{count} ");
        }
        // N = 5 -> "5, 4, 3, 2, 1"
        // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    }

    /// <summary>
    /// Сумма натуральных элементов в промежутке от M до N
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int SumBetweenMn(int m, int n)
    {
        if (n > m)
            return n + SumBetweenMn(m, n - 1);
        return m;
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30
    }

    /// <summary>
    /// Функция Аккермана
    /// При больших значениях n и m может возникнуть переполнение стека, так как функция Аккермана есть дважды рекурсивной:
    /// один из аргументов функции есть та же рекурсивная функция. 
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }

        if (m > 0 && n == 0)
        {
            return Akkerman(m - 1, 1);
        }

        return Akkerman(m - 1, Akkerman(m, n - 1));
        // m = 2, n = 3 -> A(m,n) = 9
        // m = 3, n = 2 -> A(m,n) = 29
    }
}