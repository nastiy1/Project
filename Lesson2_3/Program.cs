using System;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Постановка задачи №3: Определить, является ли введённое пользователем число чётным.

            Console.WriteLine("Введите число для определения четное или нечётное:");
            int n = Convert.ToInt16(Console.ReadLine());
            double result = n % 2;
            if (result ==0)
            {

                Console.WriteLine($"Число {n} является четным");


            }
            else

            {
                Console.WriteLine($"Число {n} является нечетным");
            }
        }
    }
}
