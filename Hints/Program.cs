﻿Console.WriteLine("Hello, World!");  // вывести текст
Console.ReadLine();  // ввести текст с клавиатуры  -> всегда возвращает строку

// Convert  -> конвертирует в нужный нам формат
// Если надо получить число.
Convert.ToInt32(Console.ReadLine());
// Если надо получить число c запятой.
Convert.ToDouble(Console.ReadLine());
// Если надо получить строку.
Convert.ToString(Console.ReadLine());

// тип данных int, string, int[], string[], bool, double, double[];  [] -> обозначаются массивы

int a; // создать числовую переменную
int[] b; // создать числовой массив;
int[] c = new int[5]; // создать числовой массив из 5 элементов
int[] c1 = new int[] { 1, 2, 3, 4, 5 }; // создать числовой массив из 5 элементов
// получить 1 элемент массива c1[0]   // 1
// получить 2 элемент массива c1[1]   // 2
// получить 3 элемент массива c1[3]   // 3
// итд

double q1 = 1.1; // тип данных принимающий числа с запятыми
double[] q2 = new double[5]; // создать числовой массив из 5 элементов с запятыми
double[] q3 = new double[] { 1.1, 2.2, 3.1, 4.5, 5.9 }; // создать числовой массив из 5 элементов

string d; // создать строковую переменную
string[] e = new String[5]; // создать строковый массив из 5 элементов
string[] e1 = new String[]{ "строка1", "строка2", "строка3", "строка4", "строка5"}; // создать строковый массив из 5 элементов
// получить 1 элемент массива e1[0]   // "строка1"
// получить 2 элемент массива e1[1]   // "строка2"
// получить 3 элемент массива e1[3]   // "строка3"
// итд

bool h = true;  // тип данных bool может принимать только 2 значения или true или false и никакие другие
bool h1 = false;

var f = 0; // заставить определить программу 
var g = Array.Empty<int>();  // создать пустой числовой массив
var j = Array.Empty<string>(); // создать пустой строковый массив

// можно обратится к любому элементу этой строки как к массиву
// допустим надо получить 1 символ строки -> text[0]
// 2 символ можно получить text[1] 
string text = "test string";

if ("условие" == "условие") // если условие правдиво то выполняется блок if 
{
    
}
else // если условие неправдиво то выполнится блок else
{
    
}

// цикл for(создаём переменную i = 0 далее пишем условие если i меньше 99 то выполняем цикл; после выполнения цикла прибавляем +1 к i написав i++
for (var i = 0; i < 99; i++)
{
    // Действие которое хотим выполнить
}
// for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
// {
//     // действия
// }


// while (условие)
// {
//     действия цикла
// }
int k = 6;
while (k > 0) // пока k > 0 выполняем цикл 
{
    // действия цикла
}

// foreach(тип_данных переменная in коллекция)
// {
//     // действия цикла
// }
foreach(char t in "Tom")
{
    Console.WriteLine(c); // выведет нам сначала букву T потом o потом m
}


// Можем цикл вложить в цикл
for (int i = 1; i < 10; i++)
{
    for (int l = 1; l < 10; l++)
    {
        Console.Write($"{i * l} \t");
    }
    Console.WriteLine();
}

// Функции

// функции бывают бывают возращающие данные и невозвращающие данные  int int[] string string[] double double[] var void

    //  firstV -> это название функции
// void firstV()  функция нам не вернёт данные просто выполнит то что внутри скобок
// {
// }

//----------------------------------------------------------------------------------------------//

// int firstI()  функция нам вернёт INT(число)
// {
// var o = 5; //Создадим переменную о и положим в неё 5;
// return o; // вернём 5 из функции 
// }

//---------------------------------------------------------------------------------------------//

// string firstS()  функция нам вернёт string(строку)
// {
// var o = "text"; //Создадим переменную о и положим в неё слово text;
// return o; // вернём text из функции 
// }


//-------------------------------------------------------------------------------------------//
// вызываем функцию вот таким методом
firstF(); // просто запускаем

// создаём(объявляем) сама по себе функция без записи выше не запустится.
void firstF()
{
    Console.WriteLine("тут выведет текст");
}

//-----------------------------------------------------------------------------------------//

// В функцию можно положить переменную или переменные и их использовать.
// 0) -> смотрим на эти цыфры это последовательность выполнения(создания)
int first = 2; // создали first и положили туда 2
int second = 5; // создали second и положили туда 5

// запускаем firstVar и кладём в функцию наши переменные first и second
//1) 
int number = firstVar(first, second); // функция вернёт нам 7 и положит её в переменную number
// 5)
Console.WriteLine(number); // и мы можем вывести
// int[то что нам вернёт функция обратно]  название функции  ( тут мы объявили int a и int b то что мы можем положить в нашу функцию) 
// int                                     firstVar            (int a, int b)
// 2)
int firstVar(int a, int b) // функция нам вернёт INT(число)
{
    // 3)
    var s = a + b; //  2 и 5 из наших first и second падают в нашу функцию в переменные a и b и мы их складываем
    // 4)
    return s; // вернём цифру 7 из функции 
}



