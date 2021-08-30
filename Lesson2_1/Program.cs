using System;

namespace Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Постановка задачи: 1.Пользователь вводит мин. и мах. температуру за сутки; 2.Вывести среднесуточную температуру за сутки.

            Console.WriteLine("Введите минимальную температуру:");
            int mint = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру:");
            int maxt = Convert.ToInt16(Console.ReadLine());
            int result = (mint + maxt) / 2;
            Console.WriteLine($"Среднесуточная температура:{result}");
        }
    }
}
