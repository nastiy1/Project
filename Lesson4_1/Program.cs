using System;

namespace Lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Написать метод GetFullName(string firstName, string lastName, string patronymic), 
             * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
             * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
                                                                                        */

            for (int i = 0; i < 3; i++)
            {
                string firstName = Firstname();
                string lastname = Lastname();
                string patronymic = Patronymic();
                string fio = GetFullName(firstName, lastname, patronymic);
            }
        }
        static string Firstname()
        {
            Console.WriteLine("Введите Имя:");
            string firstname = Console.ReadLine();
            return firstname;
        }
        static string Lastname()
        {
            Console.WriteLine("Введите Фамилию:");
            string lastName = Console.ReadLine();
            return lastName;
        }
        static string Patronymic()
        {
            Console.WriteLine("Введите Отчество:");
            string Patronymic = Console.ReadLine();
            return Patronymic;
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string FIO = String.Concat(firstName, lastName, patronymic);
            Console.WriteLine(FIO);
            return FIO;
        }
    }
}

