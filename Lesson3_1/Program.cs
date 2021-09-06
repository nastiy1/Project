using System;

namespace Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую элементы двухмерного массива по диагонали.

            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        array[i, j] = j;

                    }
                    Console.Write($"\t {array[i, j]}");

                }
                Console.WriteLine();
            }

        }
    }
}
