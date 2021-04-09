using hw4.Enums;
using hw4.Interfaces;
using hw4.Models;
using System;

namespace hw4.Managers
{
    internal class AnimalManager : IAnimalManager
    {
        public void GetInfo(Animal animal)
        {
            Console.WriteLine($"ID:{animal.GetId()}");
            Console.WriteLine($"Name:{animal.Name}");
            Console.WriteLine($"Kind:{animal.Kind}");
            Console.WriteLine($"Habitat:{animal.Habitat}");
        }

        public void Rename(Animal animal, string name)
        {
            animal.Name = name;
        }

        public Animal CreateAnimal()
        {
            return new Animal();
        }

        public Animal CreateAnimal(string name)
        {
            return new Animal(name);
        }

        public Animal CreateAnimal(string name, KindType kind)
        {
            return new Animal(name, kind);
        }

        public Animal CreateAnimal(string name, string habitat)
        {
            return new Animal(name, KindType.None, SetHabitat(habitat));
        }

        public Animal CreateAnimal(string name, KindType kind, string habitat)
        {
            return new Animal(name, kind, SetHabitat(habitat));
        }

        public Habitat SetHabitat(string habitat)
        {
            if (Enum.TryParse(habitat, true, out Habitat habitatEnum))
            {
                return habitatEnum;
            }
            return Habitat.None;
        }
    }
}
