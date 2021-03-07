using System;
using System.IO;

namespace randDate
{

    class RandDate
    {
        static void Main(string[] args)
        {
            string fileName = "RandDate.txt";
            string randDate = Console.ReadLine();
            File.WriteAllText(fileName, randDate);
        }
    }
}
