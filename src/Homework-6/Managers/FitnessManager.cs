using Homework_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Homework_6.Models;
using System.Linq;
using System.IO;
using System.Net;
using Newtonsoft.Json; //www.youtube.com/watch?v=k91jTTdr0GM

namespace Homework_6.Managers
{
    public class FitnessManager : IFitness
    {
        List<RunTracker> run = new List<RunTracker>();
        public List<int> step = new List<int>();
        List<int> pulse = new List<int>();
        public int GetSteps()
        {
            Random random = new Random();
            return random.Next(0,40001);
        }
        public int GetPulse()
        {
            Random random = new Random();
            var p = random.Next(40, 160);
            pulse.Add(p);
            return p;
        }
        public int Water(int water)
        {
            string glass;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{water} стаканов:+/-");
            Console.ResetColor();
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
                                var speed = new Random().Next(0, 30);
                                var workout = new RunTracker {TimeWorkout=stopWatch.Elapsed, Distance=speed * stopWatch.Elapsed.TotalSeconds / 60 };
                                run.Add(workout);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Running time: {0:hh\\:mm\\:ss\\.fffffff}", stopWatch.Elapsed);
                                Console.ResetColor();

                                Random rnd = new Random();
                                Enums.RunType n = (Enums.RunType)rnd.Next(3);
                                Console.WriteLine(n);
                            }
                            break;
                    }
                }
            }
            while (task != "no");
            foreach (var training in run)
            {
                Console.WriteLine($"Time {training.TimeWorkout} distance {training.Distance}");
            }
            Console.ReadKey();
        }
        public void ShowDayActivity(int water)
        {
            Console.WriteLine($"Your activity today:" +
                $"\n{run.Sum(x => x.TimeWorkout.TotalSeconds)}(seconds) and distance {run.Sum(x => x.Distance)}(kilometers)" +
                $"\n steps {step.Sum()}" +
                $"\n pulse {string.Join(";",pulse)} " +
                $"\n water {water}");
        }
        public void Weather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&appid=1d6de5c626ed1f4cef6c29a6e70b6944";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Temperature in {0}: {1} °C", weatherResponse.Name, weatherResponse.Main.Temp);
            Console.ResetColor();
        }
    }
}
