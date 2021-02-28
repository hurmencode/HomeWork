using System;

namespace Methods
{
    class FullName
    {
        static void Main()
        {
            ShowUser();
        }

        static string GetFullName()
        {
            Console.WriteLine("Приветствую, введите имя: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string secondName = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            string patronymic = Console.ReadLine();

            string result = ( secondName + " " + firstName + " " + patronymic );
            return result;
        }

        static void ShowUser ()
        {
            Console.WriteLine("Введите количество пользователей:");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] users = new string [count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = GetFullName();
                Console.WriteLine($"Пользователь {users[i]} сохранен");
            }
            
            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.Clear();

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }

        }

    }
}
