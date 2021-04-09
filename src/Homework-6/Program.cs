using Homework_6.Managers;
using Homework_6.Models;
using Homework_6.Services;
using System;

namespace Homework_6
{
    internal class Program
    {
        public static FitnessManager fitnessManager = new FitnessManager();
        public static WeatherServices weatherSetvise = new WeatherServices();
        private static int water = 0;

        public static void Main(string[] args)
        {
            weatherSetvise.Weather();
            ScreenSaver();
        }

        public static void ScreenSaver()
        {
            DateTime datenow = DateTime.Now;
            Console.WriteLine(datenow.ToString("D"));
            Console.WriteLine("{0:T}", datenow);
            Console.WriteLine(datenow.DayOfWeek);
            Console.WriteLine("1-menu");
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
            Console.WriteLine("6. Output.");
            int.TryParse(Console.ReadLine(), out int userInput);

            switch (userInput)
            {
                case 1:
                    {
                        var tracker = new FitnessTracker();
                        var steps = fitnessManager.GetSteps();
                        fitnessManager.step.Add(steps);
                        tracker.Steps = steps;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Всего шагов:{steps}");
                        Console.ResetColor();
                    }
                    break;

                case 2:
                    {
                        var tracker = new FitnessTracker();
                        var pulse = fitnessManager.GetPulse();
                        tracker.Pulse = pulse;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Ваш пульс:{pulse}");
                        Console.ResetColor();
                    }
                    break;

                case 3:
                    {
                        water = fitnessManager.Water(water);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(water);
                        Console.ResetColor();
                    }
                    break;

                case 4:
                    {
                        fitnessManager.RunType();
                    }
                    break;

                case 5:
                    {
                        fitnessManager.ShowDayActivity(water);
                    }
                    break;

                case 6:
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("1. Screen saver.");
            Console.WriteLine("2. Main menu.");
            int.TryParse(Console.ReadLine(), out int userInput);

            switch (userInput)
            {
                case 1:
                    {
                        ScreenSaver();
                    }
                    break;

                case 2:
                    {
                        MainMenu();
                    }
                    break;
            }
        }
    }
}
