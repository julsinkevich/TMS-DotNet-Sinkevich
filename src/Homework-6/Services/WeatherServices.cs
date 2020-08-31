using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json; //www.youtube.com/watch?v=k91jTTdr0GM
using Homework_6.Models;

namespace Homework_6.Services
{
    class WeatherServices
    {
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
