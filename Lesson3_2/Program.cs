using System;

namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
            string[,] phonebook = new string[5, 2];
            for (int i = 0; i < phonebook.GetLength(0); i++)
            {

                Console.WriteLine("Введите имя контакта:");
                string name = Console.ReadLine();
                phonebook[i, 0] = name;
                Console.WriteLine("Введите номер моб.телефона и адрес электронной почты:");
                string numberphone = Console.ReadLine();
                phonebook[i, 1] = numberphone;
                


            }
        }
    }
}
