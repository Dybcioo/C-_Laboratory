using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{//w klasie implementujemy interfejs gdy bedzie chcial skorzystac z bazy wspolnego kodu zdefiniowanego dla tego interfejsu
    class Horse : Animal, IHerbivorous
    {
        public Horse(int speed, string name, double height) :
           base(speed, name, height)
        {

        }
        public Horse() { }
        public void EatPlant()
        {
            Console.WriteLine($"{Name} zjadł trawe");
        }

        public void FindFood()
        {
            Console.WriteLine($"{Name} upolował trawe");
        }
    }
}
