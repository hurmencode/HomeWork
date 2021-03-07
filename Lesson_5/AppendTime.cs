using System;
using System.IO;

namespace AppendTime
{
    class AppendTime
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now.ToString();
            using var fileName = File.AppendText("startup.txt");
            fileName.WriteLine(time);
            Console.WriteLine($"Добавить в файл {time}");
        }
    }
}
