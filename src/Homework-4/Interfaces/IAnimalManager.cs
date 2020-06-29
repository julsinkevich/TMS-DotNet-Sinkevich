using hw4.Enums;
using hw4.Models;

namespace hw4.Interfaces
    {
    interface IAnimalManager
    {
       void Rename(Animal animal,string name);
       void GetInfo(Animal animal);
       Habitat SetHabitat( string Habitat);
    }
}
