using System;

namespace Month
{
    class Month
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную и максимальную температуру");
            double min = Convert.ToInt32(Console.ReadLine());
            double max = Convert.ToInt32(Console.ReadLine());
            double ave = (min + max) / 2;
            Console.WriteLine($"min= {min}; max= {max}; ave = {ave}");

            Console.WriteLine("Введите номер месяца");
            int month = Convert.ToInt32(Console.ReadLine());
            string MonthTitle = "";
            switch (month)
            {
                case 1:
                    MonthTitle = "Январь";
                    break;
                case 2:
                    MonthTitle = "Февраль";
                    break;
                case 3:
                    MonthTitle = "Март";
                    break;
                case 4:
                    MonthTitle = "Апрель";
                    break;
                case 5:
                    MonthTitle = "Май";
                    break;
                case 6:
                    MonthTitle = "Июнь";
                    break;
                case 7:
                    MonthTitle = "Июль";
                    break;
                case 8:
                    MonthTitle = "Август";
                    break;
                case 9:
                    MonthTitle = "Сентябрь";
                    break;
                case 10:
                    MonthTitle = "Октябрь";
                    break;
                case 11:
                    MonthTitle = "Ноябрь";
                    break;
                case 12:
                    MonthTitle = "Декабрь";
                    break;
            }
            Console.WriteLine(MonthTitle);
            if (month <= 3 && ave > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
