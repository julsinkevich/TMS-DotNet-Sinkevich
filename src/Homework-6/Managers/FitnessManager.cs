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
        public void Water()
        {
            var tracker = new FitnessTracker();//бред
            int water = 0;//бред
            string glass;
            Console.WriteLine("0 стаканов:+/-");
            var plus = "+";
            var minus = "-";
            glass = Convert.ToString(Console.ReadLine());
            if (glass == plus)
            {
                water += 1;
                Console.WriteLine(water);
               // return water;

            }
            else if (glass == minus & water >= 0)
            {
                water -= 1;
                Console.WriteLine(water);
             //   return water;
            }
            else
            {
                Water();
              //  return water;
            }
        }

        public void RunType()
        {
            List<RunTracker> run = new List<RunTracker>();
            //List<Note> notes = new List<Note>();
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
