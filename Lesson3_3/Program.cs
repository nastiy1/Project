using System;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
            string greeting = "Hello";
            for (int i = greeting.Length-1; i >= 0; i--)
            {
                Console.Write($"\t {greeting[i]}");
            }
        }
    }
}
