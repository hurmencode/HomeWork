using System;

namespace recursiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonachi(number));
        }

        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return n - Fibonachi(1) + (n-1)-Fibonachi(1);
            }
        }
    }
}
