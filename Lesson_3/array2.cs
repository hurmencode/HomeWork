using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = {1, 2, 3, 4, 5};

            int[,] matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.Write(m[i]);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }

            
        }
    }
}
