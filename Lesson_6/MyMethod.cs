using System;

namespace method
{
    [Serializable]
    public class MyArraySizeException : Exception { }
    class MyArrayDataException : FormatException
    {
        public MyArrayDataException(string massege)
            : base(massege)
        { }
    }

    class MyMethod
    {
        static void Main(string[] args)
        {
            string[,] fdgh = new string[4, 4] { 
                { "15", "6", "1", "1" },
                { "4", "5", "6", "4" },
                { "5", "6", "3", "4" },
                { "7", "1", "hjg", "9" } };
            Method(fdgh);
        }

        static string[,] GetArrayEx(string[,] array)
        {
            string[,] testArray = new string[4, 4];
            if (testArray.GetLength(0) != array.GetLength(0) || // Сравниваем размерности
                testArray.GetLength(1) != array.GetLength(1))
            {
                throw new MyArraySizeException();
            }
            return array;
        }

        static int DataEx(string [,] array)
        {
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int number;
                    bool result = int.TryParse(array[i, j], out number);// проверяем можноли конвертировать
                    if (result != true)
                    {
                        throw new MyArrayDataException(massege: $"Неверный символ {array[i,j]}\nКоординаты в матрице: [{i+1} {j+1}]");
                    }
                    else
                    {
                        summ = summ + Int32.Parse(array[i, j]);
                    }
                }
            }
             return summ;
        }

        static void Method(string[,] array)
        {
            try
            {
                GetArrayEx(array);
                Console.WriteLine(DataEx(array));
            }
            catch (MyArraySizeException)
            {
                Console.WriteLine("Неверная размерность массива");
            }
            catch (MyArrayDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
