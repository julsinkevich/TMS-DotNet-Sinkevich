using Homework_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using Homework_6.Models;

namespace Homework_6.Managers
{
    public class FitnessManager : IFitness
    {
        public int GetSteps()
        {
            Random random = new Random(0);
            return random.Next(20001);
        }
        public int GetPulse()
        {
            Random random = new Random();
            return random.Next(40, 160);  
        }
        public int Water(int water)
        {
            string glass;
            Console.WriteLine($"{water} стаканов:+/-");
            glass = Convert.ToString(Console.ReadLine());

            int newWater = water;
            
            if (glass == "+")
            {
                newWater += 1;
            }
            else if (glass == "-" & water >= 0)
            {
                newWater -= 1;
            }
            else
            {
                Water(water);       
            }
            return newWater;
        }
        public void RunType()
        {
            List<RunTracker> run = new List<RunTracker>();
            string task;
            do
            {
                Console.WriteLine("Let's start?(yes/no):");
                task = Console.ReadLine();
                if (task == "yes")
                {
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();

                    double d = 0;
                    for (int i = 0; i < 1000 * 1000 * 1000; i++)
                    {
                        d += 1;
                    }
                    Console.WriteLine("Enter 1 to stop:");
                    int.TryParse(Console.ReadLine(), out int userInput);

                    switch (userInput)
                    {
                        case 1:
                            {
                                stopWatch.Stop();
                                Console.WriteLine("Running time: {0:hh\\:mm\\:ss\\.fffffff}", stopWatch.Elapsed);
                            }
                            break;
                    }
                }
            }
            while (task != "no");
            Console.WriteLine("Run list:");
            Console.ReadKey();
        }
    }
}
