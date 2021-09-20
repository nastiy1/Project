// Decompiled with JetBrains decompiler
// Type: Lesson7_1.Program
// Assembly: Lesson7_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D15DF5C-7D25-4F3A-B312-78A79A121748
// Assembly location: C:\Users\nasti\Progetgithub\Project\Lesson7_1\bin\Release\net5.0\Lesson7.exe

using System;

namespace Lesson7_1
{
  internal class Program
    /*Написать любое приложение, произвести его сборку с помощью MSBuild, 
    * осуществить декомпиляцию с помощью dotPeek, внести правки в программный код и пересобрать приложение. */
    {
        private static void Main(string[] args)
    {
      string str = "2345";
      Console.WriteLine("Enter password:");
      if (Console.ReadLine() == str)
        return;
      Console.WriteLine("Welcome!");
    }
  }
}
