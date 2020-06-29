using hw4.Managers;
using hw4.Models;
using System;

namespace hw4
{
    class Program
    {
        private static readonly AnimalManager _animalManager = new AnimalManager();
        private static readonly ZooManager _zoo = new ZooManager();
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                int.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        {
                            InputAnimal();
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Введите имя:");
                            var name = Console.ReadLine();
                            _zoo.Remove(name);
                        }
                        break;

                    case 3:
                        {

                            Console.WriteLine("Введите имя:");
                            var name = Console.ReadLine();
                            _zoo.GetAnimal(name);
                        }
                        break;

                    case 4:
                        {
                            _zoo.GetAllAnimal();
                        }
                        break;

                    case 5:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Команда не найдена\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
        private static void InputAnimal()
        {
            Console.WriteLine("Введите имя:");
            Console.WriteLine("Введите среду обитания:");
            var name = Console.ReadLine();
            var habitat = Console.ReadLine();
            Animal animal;
            if (!string.IsNullOrEmpty(name))
            {
                if (!string.IsNullOrEmpty(habitat))
                {
                    animal = _animalManager.CreateAnimal(name, habitat);
                }
                else
                {
                    animal = _animalManager.CreateAnimal(name);
                }
            }
            else
            {
                animal = _animalManager.CreateAnimal();
            }

            _zoo.SetAnimal(animal);

            Console.WriteLine("Животное добавлено в зоопарк!\n");
        }
        private static void ShowMenu()
        {
            DateTime dateNow = DateTime.Now;
            Console.WriteLine(dateNow.ToLongDateString());
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1.Добавить животное");
            Console.WriteLine("2.Удалить животное");
            Console.WriteLine("3.Показать животное");
            Console.WriteLine("4.Показать всех животных");
            Console.WriteLine("5.Выход");
            Console.WriteLine();
        }
    }
}
