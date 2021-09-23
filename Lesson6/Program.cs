using System;
using System.Diagnostics;
using System.Linq;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать консольное приложение Task Manager,
          * которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
          * Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
          * В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
*/

            var runningProcs = from proc in Process.GetProcesses(".")
                               orderby proc.ProcessName
                               select proc;


            foreach (var proc in runningProcs)
            {
                Console.WriteLine($"--->PID: {proc.Id}\t Name:{proc.ProcessName}");

            }

            try
            {
                Console.WriteLine("Введите PID процесса:");
                int pid = Convert.ToInt32(Console.ReadLine());
                Process Id = Process.GetProcessById(pid);

                Id.Kill();


                Console.WriteLine("Введите имя процесса:");
                string name = Console.ReadLine();
                foreach (var proc in Process.GetProcessesByName(name))
                {
                    proc.Kill();
                }

            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Что-то пошло не так");
                int pid = Convert.ToInt32(Console.ReadLine());
                Process Id = Process.GetProcessById(pid);

                Id.Kill();

            }
            catch (InvalidOperationException name)
            {
                Console.WriteLine("Ошибка");

            }


        }
    }
}
