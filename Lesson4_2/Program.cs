using System;
using System.Linq;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
             * и возвращающую число — сумму всех чисел в строке. 
             * Ввести данные с клавиатуры и вывести результат на экран.*/


            int sum = SSum();

            static int SSum()
            {
                Console.WriteLine("Введите числа:");
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), (numbers) => Convert.ToInt32(numbers));
                int result = numbers.Sum();
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
