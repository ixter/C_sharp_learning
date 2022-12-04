namespace Task1;

class SignsShower
{
    private int _heightWindow;
    private int _widthWindow;
    private int[] _widthPosSimple;
    private int[] _widthPosAddition;

    private readonly Sign _sign = new Sign();

    //ctor
    public SignsShower() : this((Console.WindowWidth - 1), Console.WindowHeight)
    { }
    /// <summary>
    /// Отображатель символов
    /// </summary>
    /// <param name="windowWidth">ширина консольного окна минус 1</param>
    /// <param name="windowHeight">высота консольного окна</param>
    public SignsShower(int windowWidth, int windowHeight)
    {
        Initialization(windowWidth, windowHeight);
    }

    private void Initialization(int windowWidth, int windowHeight)
    {
        //получаем высоту окна
        _heightWindow = windowHeight;

        int h1 = _heightWindow / 2; //половина высоты
        int h2 = _heightWindow / 4; //четверть высоты

        //ширина окна
        _widthWindow = windowWidth;

        //два массива размером в ширину окна
        _widthPosSimple = new int[_widthWindow];
        _widthPosAddition = new int[_widthWindow];

        //заполнение массивов случайными числами
        for (int i = 0; i < _widthWindow; i++)
        {
            _widthPosSimple[i] = Sign.RandomGen.Next(_heightWindow);

            int k = (i % 11 != 10) ? 2 : 1;
            int min = h2 * k;
            int max = h1 * k;
            _widthPosAddition[i] = Sign.RandomGen.Next(min, max);
        }
    }

    /// <summary>
    /// Отображение символов в случайных позициях с необх.цветом
    /// </summary>
    public void SignShow()
    {
        for (int i = 0; i < _widthWindow; i++)
        {
            if (_widthPosSimple[i] < 10)
            {
                //отображение темного символа
                _sign.ShowDarkGreenSign(i, _widthPosSimple[i]);
            }
            else if (_widthPosSimple[i] < 25)
            {
                //отображение зеленого символа
                _sign.ShowGreenSign(i, _widthPosSimple[i]);
            }
            else
            {
                //отображаем белый символ
                _sign.ShowWhiteSign(i, _widthPosSimple[i]);
            }

            //сдвигаем координату по высоте для отображения в след. цикле вызова SignShow()
            _widthPosSimple[i] = CheckNextHeightPosition(_widthPosSimple[i] + 1, _heightWindow);

            //пробельный символ
            int next = _widthPosSimple[i] - _widthPosAddition[i];
            int nextPos = CheckNextHeightPosition(next, _heightWindow);
            _sign.ShowSpaceSign(i, nextPos);
        }
    }

    /// <summary>
    /// Проверка значения след.позиции
    /// </summary>
    /// <param name="next">значение след.положения по высоте</param>
    /// <param name="height">общая допустимая высота</param>
    /// <returns></returns>
    private int CheckNextHeightPosition(int next, int height)
    {
        next = next % height;

        if (next < 0)
        {
            return next + height;
        }
        else
        {
            return next;
        }

    }
}