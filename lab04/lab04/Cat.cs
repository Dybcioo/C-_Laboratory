using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Cat : Animal, ICarnivorous
    {
        public Cat(int speed, string name, double height) :
           base(speed, name, height)
        {

        }
        public Cat() { }

        public void EatMeat()
        {
            Console.WriteLine($"{Name} zjadł mysz");
        }

        public void FindFood()
        {
            Console.WriteLine($"{Name} upolował mysz");
        }
    }
}
