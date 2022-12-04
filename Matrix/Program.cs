using System;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //отображатель
            SignsShower signsShower = new SignsShower();

            //готовим консоль
            Console.Clear();
            Console.CursorVisible = false;

            //в бесконечном цикле с вычисляемой задержкой отображаем
            int ms = 0;
            while (true)
            {
                //засекаем время
                DateTime timeMark = DateTime.Now;
                //отображаем символы
                signsShower.SignShow();

                //задержка
                ms = 10 - (int)((TimeSpan)(DateTime.Now - timeMark)).TotalMilliseconds;
                if (ms > 0) System.Threading.Thread.Sleep(ms);
            }

        }
    }
}