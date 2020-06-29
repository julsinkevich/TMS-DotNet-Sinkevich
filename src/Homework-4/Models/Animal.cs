using hw4.Enums;
using System;

namespace hw4.Models
{
    class Animal
    {
        private readonly Guid _id = Guid.NewGuid();
        public Animal()
        {
            
        }

        public Animal(string name)
        {
            Name = name;
            Kind = KindType.None;
            Habitat = Habitat.None;
        }
        public Animal(string name, KindType kind)
        {
            Name = name;
            Kind = kind;

        }
        public Animal(string name, KindType kind, Habitat habitat)
        {
            Name = name;
            Kind = Kind;
            Habitat = habitat;
        }
        public string Name { get; set; }
        public KindType Kind { get; set; }
        public Guid GetId()
        {
            return _id;
        }
        public Habitat Habitat { get; set; }
        public DateTime Date { get; set; }
    }
}
