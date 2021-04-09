using System;

namespace Homework_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Если хотите узнать, какой сегодня день - введите '1'. " +
            "Если хотите узнать, какой был день недели определенной даты -введите '2'.");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice != 1 && choice != 2)
            {
                Console.WriteLine("Ошибка.");
                Console.Write("Введите число заново: ");
            }
            if (choice == 1)
            {
                DisplayCurrentDate();
            }
            else
            {
                GetEnteredDate();
            }
            DateTime dateNow = DateTime.Now;
            DateTime enteredDate = GetEnteredDate();

            CalculateData(dateNow, enteredDate);

            Console.ReadKey();
            Console.Clear();
        }

        private static void DisplayCurrentDate()
        {
            var datenow = DateTime.Now;
            DisplayDate(datenow);
        }

        private static DateTime GetEnteredDate()
        {
            int year;
            int month;
            int day;
            Console.WriteLine("Введите год в формате 'хххх'");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц в формате 'хх'");
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
            var date = new DateTime(year, month, day);
            DisplayDate(date);

            return date;
        }

        private static void DisplayDate(DateTime date)
        {
            Console.WriteLine("Date time:" + date.ToLongDateString());
            Console.WriteLine("Day of week:" + date.DayOfWeek);
            Console.WriteLine("Day of year:" + date.DayOfYear);
        }

        private static void CalculateData(DateTime dateNow, DateTime enteredDate)
        {
            Console.WriteLine("Calculate Date");
            if (dateNow > enteredDate)
            {
                Console.WriteLine(dateNow.Subtract(enteredDate));
            }
            else if (dateNow < enteredDate)
            {
                Console.WriteLine(enteredDate.Subtract(dateNow));
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}