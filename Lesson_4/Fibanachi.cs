using System;

namespace recursiv
{
    class Fibanachi
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
        static int Fib(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return (number -1) + (number - 2);
            }
            
        }

    }
}
