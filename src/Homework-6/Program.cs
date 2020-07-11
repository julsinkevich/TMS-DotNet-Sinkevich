using System;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Screensaver();
        }
        static void Screensaver()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("{0:T}", now);
            Console.WriteLine(now.ToString("dddd"));
            Console.WriteLine("menu or 1");
            Console.ReadLine();
            int menu;
            while (!int.TryParse(Console.ReadLine(), out menu) || menu != 1)
            { Console.WriteLine("пустота"); }
             if (menu == 1)
            { }    
            else
            {
            }
        }
    }
}
