using System;

namespace Lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // * «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

            string[,] array = new string[10, 10];

            array[1, 0] = "X";
            array[1, 1] = "X";
            array[1, 2] = "X";
            array[1, 3] = "X";

            array[5, 0] = "X";
            array[5, 1] = "X";
            array[5, 2] = "X";

            array[3, 7] = "X";
            array[3, 8] = "X";
            array[3, 9] = "X";

            array[6, 4] = "X";
            array[6, 5] = "X";

            array[7, 2] = "X";
            array[7, 3] = "X";

            array[7, 2] = "X";
            array[7, 3] = "X";

            array[9, 9] = "X";

            array[9, 0] = "X";






            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] != "X")
                    {
                        array[i, j] = "O";
                    }
                    Console.Write($"\t {array[i, j]}");
                }

                Console.WriteLine();
            }


        }
    }
}
