using System;


namespace Lesson2_2
{
    class Program

    {
        
        enum Mouth
        {
            January=1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            //Постановка задачи: 1.Пользователь вводит порядковый номер текущего месяца; 2.Выести название месяца.


            Console.WriteLine("Введите номер текущего месяца:");
            int mumericmouth = Convert.ToInt16(Console.ReadLine());

            switch (mumericmouth)
            {
                case 1:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.January}");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.February}");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.March}");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.April}");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.May}");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.June}");
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.July}");
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.August}");
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.September}");
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.October}");
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.November}");
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine($"Текущий месяц:{Mouth.December}");
                    }
                    break;

                default:
                    Console.WriteLine("Укажите значение от 1 до 12");
                    break;


                    
            }
        

        }
    }
}
