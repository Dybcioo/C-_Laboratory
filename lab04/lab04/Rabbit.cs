using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Rabbit : Animal, IHerbivorous
    {
        public Rabbit(int speed, string name, double height) :
           base(speed, name, height)
        {

        }

        public Rabbit() { }
        public void EatPlant()
        {
            Console.WriteLine($"{Name} zjadl marchewke");
        }

        public void FindFood()
        {
            Console.WriteLine($"{Name} upolowal marchewke");
        }
    }
}
