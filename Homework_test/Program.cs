Console.WriteLine(
    "Задача: Написать программу, которая из имеющегося массива строк формируст массив из строк, длина которых \n"
    + "меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте \n"
    + "выполнения алгоритма. При решении но рекомендуется пользоваться коллекциями, лучше обойтись \n"
    + "исключительно массивами.");
Console.WriteLine();
var gettext = GetAnyArray("Введите элементы массива через пробел или запятую -> ", true);
var text = SelectLessThreeCharText(gettext);

string[] SelectLessThreeCharText(string[] arr)
{
    string[] text = Array.Empty<string>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Array.Resize(ref text, text.Length + 1);
            text[text.Length - 1] = "\"" + arr[i] + "\"";
        }
    }
    return text;
}

string[] GetAnyArray(string outputText = "", bool inline = false)
{
    var arrays = Array.Empty<string>();
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
            arrays = Array.ConvertAll(arrayOfEnteredText, s => s);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }

    return arrays;
}