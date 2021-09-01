using System;

namespace Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nomerticket = 005818;
            long nomerseriy = 0294990088519013;
            int nomermarshrut = 31;
            string nomerbus = "P 697 CP";
            double cost = 24.00;

            Console.WriteLine("Добро пожаловать !");
            Console.WriteLine("ООО ПАП-5");
            Console.WriteLine($"Билет № {nomerticket}");
            Console.WriteLine($"Серия {nomerseriy}");
            Console.WriteLine(("15.08.2019 14:10"), DateTime.Today.GetDateTimeFormats());
            Console.WriteLine($"Маршрут:№ {nomermarshrut}");
            Console.WriteLine($"Автобус {nomerbus}");
            Console.WriteLine($"Сумма: {cost} руб.");




        }
    }
}
