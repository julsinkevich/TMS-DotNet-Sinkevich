using System;
using System.Globalization;
using System.Collections.Generic;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Note> notes = new List<Note>();
            string task;
            Console.WriteLine("Notes:");
            do
            {
                Console.WriteLine("Do you want create a task?(yes/no):");
                task = Console.ReadLine();
                if (task == "yes")
                {
                    notes.Add(new Note(InputMessage(), InputDate()));
                }
            }
            while (task != "no");
            Console.WriteLine("View tasks:");
            foreach (Note note in notes)
            {
                Console.WriteLine(note.Message + " " + note.Date.ToString("MM:dd:yyyy HH:mm"));
            }

            Console.ReadKey();
        }

        static string InputMessage()
        {
            Console.WriteLine("Message text:");
            return Console.ReadLine();
        }

        static DateTime InputDate()
        {
            Console.WriteLine("Enter date: \"month:day:year hour:minute\" ");
            DateTime dateInput;
            while (!DateTime.TryParse(Console.ReadLine(),
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None, out dateInput))
            {
                Console.WriteLine("Error.");
                Console.Write("Try again. ");
            }
            return dateInput;
        }
    }

    class Note
    {
        public string Message;
        public DateTime Date;

        public Note(string message, DateTime date)
        {
            Message = message;
            Date = date;
        }
    }
}