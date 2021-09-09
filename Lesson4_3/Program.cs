using System;

namespace Lesson4_3
{
    class Program

    {
        enum Season
        {
            Numericmouth,
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            /*Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
             * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
             * Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
             * Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
             * Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
        
 */
            Console.WriteLine("Ведите номер месяца:");
            Console.WriteLine(sSeason(Numericmouth(Convert.ToInt32(Console.ReadLine()))));

        }

        static Season Numericmouth(int Numericmouth)
        {

            switch (Numericmouth)
            {
                case 1:
                    return Season.Winter;
                case 2:
                    return Season.Winter;
                case 3:
                    return Season.Spring;
                case 4:
                    return Season.Spring;
                case 5:
                    return Season.Spring;
                case 6:
                    return Season.Summer;
                case 7:
                    return Season.Summer;
                case 8:
                    return Season.Summer;
                case 9:
                    return Season.Autumn;
                case 10:
                    return Season.Autumn;
                case 11:
                    return Season.Autumn;
                case 12:
                    return Season.Winter;

                default:
                    Console.WriteLine("Введите число от 1 до 12");

                    return Season.Numericmouth;
            }



        }

        static string sSeason(Season S)
        {
            switch (S)
            {
                case Season.Winter:
                    return "Зима";
                case Season.Spring:
                    return "Весна";
                case Season.Summer:
                    return "Лето";
                case Season.Autumn:
                    return "Осень";
                default: return "";
            }
        }



    }
}



