using System;

namespace seasons
{
    class seasons
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            Loop();
        }

        static void Loop() // Рекурсия
        {
            Console.WriteLine("Введите номер месяца");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 12) 
            {
                Seasons(num);
            }
            else if(num > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12»");
                Loop();
            }
            
        }

        static int Seasons(int numberMonth)
        {
            switch (numberMonth)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine(Season.Winter);
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine(Season.Spring);
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine(Season.Summer);
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine(Season.Autumn);
                    break;
            }
            return numberMonth;
        }
    }
}
