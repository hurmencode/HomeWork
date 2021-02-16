using System;

namespace Lesson_2
{
    class MinMaxTemp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную и максимальную температуру");
            double min = Convert.ToInt32(Console.ReadLine());
            double max = Convert.ToInt32(Console.ReadLine());
            double ave = (min + max) / 2;
            Console.WriteLine($"min= {min}; max= {max}; ave = {ave}");
        }
    }
}
