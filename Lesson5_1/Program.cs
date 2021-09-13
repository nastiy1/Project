using System;
using System.IO;

namespace Lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
    */
            string path = @"C:\Users\nasti\source\repos\Text.txt";
            string createtext = Console.ReadLine();
            StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(createtext);
                sw.Close();
            
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
