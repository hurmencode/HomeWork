using System;

namespace phone_directory
{
    class phone_dir
    {
        static void Main(string[] args)
        {
            string[] name = { "1. Вася ", "2. Петя ", "3. Миша ", "4. Маша ", "5. Катя " };
            string[] phone = { "89995524654", "89998824633", "89205524633", "89155584633", "89835514633"};

            int[,] phdir = new int[5, 2];

            for (int i = 0; i < phdir.GetLength(0); i++)
            {
                Console.Write(name[i]);
                for (int j = 1; j < phdir.GetLength(1); j++)
                {
                     Console.Write(phone[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
