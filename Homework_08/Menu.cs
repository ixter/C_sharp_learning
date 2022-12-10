namespace Homework_08;

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
    
    public static int WorkingMenu(string[] menuItems)
    {
        Console.WriteLine("Меню");
        Console.WriteLine();

        var row = Console.CursorTop;
        var col = Console.CursorLeft;
        var index = 0;
        while (true)
        {
            // для разообразия выкинул в отдельный класс
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
                    return index;
            }
        }
    } 
    
}