using System.Text;

public class Homework_04
{
    public static void Main()
    {
        // внутри функции 2 вида ввода
        Exercise_25();

        // true - false переключает функциональное решение и математическое
        // Exercise_27(false);

        // Exercise_29();
    }

    /// <summary>
    /// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    /// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    /// 6, 1, 33 -> [6, 1, 33]
    /// </summary>
    static void Exercise_29()
    {
        var numbers = Array.Empty<int>();
        string start, end;
        numbers = EnterNumbers(arr: true);
        for (var i = 0; i < numbers.Length; i++)
        {
            start = i == 0 ? "[" : "";
            end = i == numbers.Length-1 ? "]" : ", ";
            Console.Write(start + numbers[i] + end);
        }
    }

    /// <summary>
    /// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    /// 452 -> 11
    /// 82 -> 10
    /// 9012 -> 12
    /// </summary>
    /// <param name="type">bool</param>
    static void Exercise_27(bool type = true)
    {
        var enteredNumber = EnterNumber(1);
        var finalNumber = 0;
        var number = 0;

        if (type)
        {
            number = enteredNumber;
            while (number > 0)
            {
                finalNumber += number % 10;
                number /= 10;
            }
            Console.WriteLine($"{enteredNumber} -> {finalNumber}");
        }
        else
        {
            // число преобразуем в текст и юзаем разбивку на символьно далее перебираем и парсим с преобразованием из чара в инт и суммируем.
            Console.WriteLine(
                $"{enteredNumber} -> {enteredNumber.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Sum()}");
        }
    }
    
/// <summary>
///Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/// 3, 5 -> 243 (3⁵)
/// 2, 4 -> 16
/// </summary>
    static void Exercise_25()
    {
        int num1 = 0, num2 = 0;
        int[] numbers = Array.Empty<int>();
        
        // первый вариант ввода чисел
        // num1 = EnterNumber(1);
        // num2 = EnterNumber(2);

        // второй вариант ввода чисел в одну строку через запятую.
        numbers = EnterNumbers(2);
        if (numbers.Length == 2)
        {
            num1 = numbers[0];
            num2 = numbers[1];
        }

        // обработка ошибок.
        try
        {
            // варианты передачи переменных в функцию [math] через математику, а [func] через Math.Pow 
            // Power(num1, num2, "func");
            Power(num1, num2, "math");
            // Power(num2: num2, num1: num1, type:"func");
            // Power(num2: num2, num1: num1, type:"math");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


/*---------------------------------------------------------------------------------------------------------------------*/


/// <summary>
/// функция возведения в степень
/// </summary>
/// <param name="num1"></param>
/// <param name="num2"></param>
/// <param name="type"></param>
    static void Power(int num1 = 0, int num2 = 0, string type = "math")
    {
        if (num1 != 0 && num2 != 0 && type == "math")
        {
            Console.WriteLine($"{num1}, {num2} -> {GetMathematicPow(num1, num2)} ({num1}{GetSupChars(num2)})");
        }
        else if (num1 != 0 && num2 != 0 && type == "func")
        {
            Console.WriteLine($"{num1}, {num2} -> {Math.Pow(num1, num2)} ({num1}{GetSupChars(num2)})");
        }
        else
        {
            Console.WriteLine("Некорректные значения");
        }
    }
/// <summary>
/// функция ввода 1 числа
/// </summary>
/// <param name="number">int</param>
/// <returns>int value</returns>
    static int EnterNumber(int number)
    {
        Console.Write($"Введите число {number}: ");
        return Convert.ToInt32(Console.ReadLine());
    }


/// <summary>
/// Функция ввода чисел и генерации массива
/// </summary>
/// <param name="number">int</param>
/// <param name="arr">bool</param>
/// <returns>int array</returns>
    static int[] EnterNumbers(int number = 2, bool arr = false)
    {
        var numbersArr = Array.Empty<int>();
        
        if (arr)
            Console.Write("Введите число для генерации массива: ");
        else
            Console.Write($"Введите {number} {Padezh(number)} через запятую пример(1, 2): ");
        
        var enteredText = Console.ReadLine();
        if (!arr && enteredText != null)
        {
            var arrZap =
                enteredText.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            numbersArr = new int[arrZap.Length];
            for (var i = 0; arrZap.Length > i; i++)
            {
                numbersArr[i] = Convert.ToInt32(arrZap[i]);
            }
        }else if (arr && enteredText != null)
        {
            numbersArr = new int[Convert.ToInt32(enteredText)];
            for(var i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = new Random().Next(1, 9);
            }
        }

        return numbersArr;
    }
/// <summary>
///  функция вычисления математичского возведения в степень
/// </summary>
/// <param name="num1">int</param>
/// <param name="num2">int</param>
/// <returns>int</returns>
    static int GetMathematicPow(int num1 = 0, int num2 = 0)
    {
        var multipliedNumber = 1;
        for (var i = 1; i <= num2; i++)
        {
            multipliedNumber *= num1;
        }
        return multipliedNumber;
    }

/// <summary>
/// получает число и раскладывает его на sup элементы
/// </summary>
/// <param name="number"></param>
/// <returns></returns>
    static string GetSupChars(int number)
    {
        // для работы юникода, разница в кодировках системы и консоли.
        Console.OutputEncoding = Encoding.UTF8;
        var s = string.Empty;
        foreach (var item in number.ToString())
        {
            switch (item)
            {
                case '0':
                    s += '\u2070';
                    break;
                case '1':
                    s += '\u00B9';
                    break;
                case '2':
                    s += '\u00B2';
                    break;
                case '3':
                    s += '\u00B3';
                    break;
                case '4':
                    s += '\u2074';
                    break;
                case '5':
                    s += '\u2075';
                    break;
                case '6':
                    s += '\u2076';
                    break;
                case '7':
                    s += '\u2077';
                    break;
                case '8':
                    s += '\u2078';
                    break;
                case '9':
                    s += '\u2079';
                    break;
                default:
                    break;
            }
        }

        return s;
    }
/// <summary>
///  падежи для чисел
/// </summary>
/// <param name="number"></param>
/// <returns></returns>
    public static string Padezh(int number)
    {
        var titles = new[] { "Число", "Числа", "Чисел" };
        var cases = new[] { 2, 0, 1, 1, 1, 2 };
        return titles[number % 100 > 4 && number % 100 < 20 ? 2 : cases[(number % 10 < 5) ? number % 10 : 5]];
    }
}