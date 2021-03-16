using System;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonClass[] people = new PersonClass[5];
            people[0] = new PersonClass("Караульных", "Илья", "Владимирович", 25, 89206149880, 40000, "Прогер", "karaulnihiv@gmail.com");
            people[1] = new PersonClass("Караульных", "Илья", "Владимирович", 45, 89206149880, 40000, "Прогер", "karaulnihiv@gmail.com");
            people[2] = new PersonClass("Караульных", "Илья", "Владимирович", 15, 89206149880, 40000, "Прогер", "karaulnihiv@gmail.com");
            people[3] = new PersonClass("Караульных", "Илья", "Владимирович", 55, 89206149880, 40000, "Прогер", "karaulnihiv@gmail.com");
            people[4] = new PersonClass("Караульных", "Илья", "Владимирович", 5, 89206149880, 40000, "Прогер", "karaulnihiv@gmail.com");

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age>=40)
                {
                    people[i].GetInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
