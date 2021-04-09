using hw4.Models;
using System;
using System.Collections.Generic;

namespace hw4.Managers
{
    internal class ZooManager
    {
        private readonly AnimalManager _animalManager;

        public List<Animal> animals = new List<Animal>();

        public ZooManager()
        {
            _animalManager = new AnimalManager();
        }

        public void GetAnimal(string name)
        {
            var animal = FindAnimal(name);
            if (animal != null)
            {
                _animalManager.GetInfo(animal);
            }
            else
            {
                Console.WriteLine("Животнoгo в зоопарке нет.");
            }
        }

        public void GetAllAnimal()
        {
            if (animals.Count > 0)
            {
                DateTime dateNow = DateTime.Now;
                Console.WriteLine(dateNow.ToLongDateString());
                foreach (var animal in animals)
                {
                    _animalManager.GetInfo(animal);
                }
            }
            else
            {
                Console.WriteLine("Животных в зоопарке нет.");
            }
        }

        public void SetAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void Remove(string name)
        {
            var animal = FindAnimal(name);
            animals.Remove(animal);
        }

        private Animal FindAnimal(string name)
        {
            foreach (var animal in animals)
            {
                if (animal.Name.ToLower() == name.ToLower())
                {
                    return animal;
                }
            }
            return null;
        }
    }
}
