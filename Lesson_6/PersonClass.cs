using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class PersonClass
    {
        public string Name;
        public string Surname;
        public string Patronymic;

        public int Age;

        public long PhoneNumber;

        public int Salary;

        public string Post;

        public string Email;

        public PersonClass(string surname, string name, string patron, 
            int age, long phone, int salary, string post, string email) { Surname = surname; Name = name;
            Patronymic = patron; Age = age; PhoneNumber = phone; Salary = salary; Post = post; Email = email;
        }
        public void GetInfo()
        {
            Console.WriteLine($"ФИО сотрудника:\n {Surname}  {Name}  {Patronymic}\n" +
                $"Возраст:\n {Age}\n Телефонный номер:\n {PhoneNumber}\n ЗП:\n {Salary}\n" +
                $" Должность:\n {Post}\n Адрес электронной почты:\n {Email}");
        }
    }
}
