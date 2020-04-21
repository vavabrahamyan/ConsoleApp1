using System;
using System.Collections;
using System.Threading;

namespace IdleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Համակարգը գեներացնում է քառանիշ թիվ
            //User-ը գրում է իր քառանիշ թիվը
            //Համակարգը գրում է համնկնող թվերի քանակը և դրանց դիրքերը

            Game.GameDisplay();

            Console.ReadLine();
        }
    }
}
