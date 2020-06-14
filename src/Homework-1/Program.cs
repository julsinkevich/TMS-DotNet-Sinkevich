using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если хотите узнать какой сегодня день - введите '1'. " +
                "Еcли хотите узнать какой был день недели -введите '2'.");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice != 1 && choice != 2)
            {
                Console.WriteLine("Ошибка.");
                Console.Write("Введите число заново: ");
            }
            if (choice == 1)
            {
                Console.WriteLine("Date time:" + DateTime.Now);
                Console.WriteLine("Date time (UTC):" + DateTime.UtcNow);
                DateTime dt = DateTime.Now;
                Console.WriteLine("Day of week:" + dt.DayOfWeek);
                Console.WriteLine("Day of year:" + dt.DayOfYear);
            }
            else if (choice == 2)
            {
            int year, month, day;
            Console.WriteLine("Введите год в формате 'хххх'");
                year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц в формате 'хх'");
                // month = int.Parse(Console.ReadLine());
                var min = 1;
                var max = 12;
                while (!int.TryParse(Console.ReadLine(), out month) || month < min || month > max)
                {
                    Console.WriteLine("Ошибка.");
                    Console.Write("Введите месяц заново: ");
                }
                Console.WriteLine("Введите день в формате 'хх'");                         
                while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                {
                    Console.WriteLine("Ошибка.");
                    Console.Write("Введите день заново: ");
                }
                DateTime dt1 = new DateTime(year, month, day);
                Console.WriteLine(dt1.ToLongDateString());
                Console.WriteLine("Day of week:" + dt1.DayOfWeek);
                Console.WriteLine("Day of year:" + dt1.DayOfYear);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}