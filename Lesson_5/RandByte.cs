using System;
using System.IO;

namespace randByte
{
    class RandByte
    {
        static void Main(string[] args)
        {
            string fileName = "RandByte.bin";
            Console.WriteLine("Введите число элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());

            byte [] randByte = new byte[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент массива");
                randByte[i] = Convert.ToByte(Convert.ToInt32(Console.ReadLine()));
            }

            File.WriteAllBytes(fileName, randByte);
            byte [] fromfile = File.ReadAllBytes(fileName);
            foreach (var item in fromfile)
            {
                Console.WriteLine(item);
            }
        }
    }
}
