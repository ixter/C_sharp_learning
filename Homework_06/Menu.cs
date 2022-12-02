namespace Homework_06;

public class Menu
{
    /// <summary>
    ///  Функция отрисовки меню с получаемыми параметрами
    /// </summary>
    /// <param name="items"></param>
    /// <param name="row"></param>
    /// <param name="col"></param>
    /// <param name="index"></param>
    public static void DrawMenu(string[] items, int row, int col, int index)
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