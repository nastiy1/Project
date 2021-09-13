using System;
using System.IO;
namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Написать программу, которая при старте дописывает текущее время в файл «startup.txt».*/
            string path = @"C:\Users\nasti\source\repos\Startup.txt";
            StreamWriter sw = new StreamWriter(path, true);
            {
                sw.WriteLine(DateTime.Now); 
                sw.Close(); 
            }
        }
    }
}
