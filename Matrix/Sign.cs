namespace Task1;

class Sign
{
    //генератор будем использовать в этом классе и снаружи
    public static Random RandomGen = new Random();

    /// <summary>
    /// Получение случайного знака
    /// </summary>
    /// <returns></returns>
    private char GetSign()
    {
        int t = RandomGen.Next(10);
        if (t <= 2)
            return (char)('0' + RandomGen.Next(10));
        else if (t <= 4)
            return (char)('a' + RandomGen.Next(27));
        else if (t <= 6)
            return (char)('A' + RandomGen.Next(27));
        else
            return (char)(RandomGen.Next(32, 255));
    }

    /// <summary>
    /// Отображение случайного символа белого цвета
    /// </summary>
    /// <param name="left">позиция слева</param>
    /// <param name="top">позиция от верха</param>
    public void ShowWhiteSign(int left, int top)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(left, top);
        Console.Write(GetSign());
    }

    /// <summary>
    /// Отображение случайного символа зеленого цвета
    /// </summary>
    /// <param name="left">позиция слева</param>
    /// <param name="top">позиция от верха</param>
    public void ShowGreenSign(int left, int top)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(left, top);
        Console.Write(GetSign());

        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Отображение случайного символа темного зеленого цвета
    /// </summary>
    /// <param name="left">позиция слева</param>
    /// <param name="top">позиция от верха</param>
    public void ShowDarkGreenSign(int left, int top)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(left, top);
        Console.Write(GetSign());

        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Отображение пробела в нужном месте
    /// </summary>
    /// <param name="left">позиция слева</param>
    /// <param name="top">позиция от верха</param>
    public void ShowSpaceSign(int left, int top)
    {
        Console.SetCursorPosition(left, top);
        Console.Write(' ');
    }
}