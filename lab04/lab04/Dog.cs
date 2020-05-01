using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Dog : Animal, ICarnivorous
    {
        public Dog(int speed, string name, double height) :
            base(speed, name, height)
        {

        }

        public Dog() { }

        public void EatMeat()
        {
            Console.WriteLine($"{Name} zjadł kota ");
        }

        public void FindFood()
        {
            Console.WriteLine($"{Name} upolował kota");
        }
    }
}
