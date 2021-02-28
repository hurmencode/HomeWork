using System;

namespace Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            int sum = GetSum(Console.ReadLine());
            Console.WriteLine(sum);
        }

        static int GetSum(string str)
        {
            int sum = 0;
            string[] word = str.Split(' ');
            foreach (var numbers in word)
            {
                sum += Convert.ToInt32(numbers) ;
            }
            return sum;
        }

        
    }
}
