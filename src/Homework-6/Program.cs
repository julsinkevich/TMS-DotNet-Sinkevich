using Homework_6.Managers;
using Homework_6.Models;
using System;

namespace Homework_6
{
    class Program
    {
        public static FitnessManager fitnessManager = new FitnessManager();
        private static int water = 0;
        public static void Main(string[] args)
        {
            ScreenSaver();
        }
        public static void ScreenSaver()
        {
            DateTime datenow = DateTime.Now;
            Console.WriteLine(datenow.ToString("D"));
            Console.WriteLine("{0:T}", datenow);
            Console.WriteLine(datenow.DayOfWeek);
            Console.WriteLine("menu-1");
            int menu;
            while (!int.TryParse(Console.ReadLine(), out menu) || menu != 1)
            {
                Console.WriteLine();
            }
            if (menu == 1)
            {
                MainMenu();
            }
            else
            {
                ScreenSaver();
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("1. Steps.");
            Console.WriteLine("2. Pulse.");
            Console.WriteLine("3. Water.");
            Console.WriteLine("4. Run.");
            Console.WriteLine("5. View daily activities.");
            Console.WriteLine("6. Add activity.");
            Console.WriteLine("7. Output.");
            int.TryParse(Console.ReadLine(), out int userInput);

            switch (userInput)
            {
                case 1:
                    {
                        var tracker = new FitnessTracker();
                        var steps = fitnessManager.GetSteps();
                        tracker.Steps = steps;
                        Console.WriteLine($"Всего шагов:{steps}");
                    }
                    break;
                case 2:
                    {
                        var tracker = new FitnessTracker();
                        var pulse = fitnessManager.GetPulse();
                        tracker.Pulse = pulse;
                        Console.WriteLine($"Ваш пульс:{pulse}");
                    }
                    break;
                case 3:
                    {
                        water = fitnessManager.Water(water);
                        Console.WriteLine(water);
                    }
                    break;
                case 4:
                    {

                    }
                    break;
                case 5:
                    {

                    }
                    break;
                case 6:
                    {

                    }
                    break;
                case 7:
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
            MainMenu();
        }
    }
}
