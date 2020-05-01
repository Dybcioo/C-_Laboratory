using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Boar : Animal, ICarnivorous, IHerbivorous
    {
        public Boar(int speed, string name, double height) :
           base(speed, name, height)
        {

        }
        public Boar() { }
        public void EatMeat()
        {
            Console.WriteLine($"{Name} zjadł dzdzownice");
        }

        public void EatPlant()
        {
            Console.WriteLine($"{Name} zjadł grzyba");
        }

        void IHerbivorous.FindFood()
        {
            Console.WriteLine($"{Name} upolowal grzyba");
        }

        void ICarnivorous.FindFood()
        {
            Console.WriteLine($"{Name} upolowal dzdzownice");
        }
    }
}
