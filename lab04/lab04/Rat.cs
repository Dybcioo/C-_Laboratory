using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Rat : Animal, IHerbivorous, ICarnivorous
    {
        public Rat(int speed, string name, double height) :
           base(speed, name, height)
        {

        }
        public Rat() { }
        public  void EatMeat()
        {
            Console.WriteLine($"{Name} zjadł padline");
        }

        public void EatPlant()
        {
            Console.WriteLine($"{Name} zjadł korzen");
        }

        void IHerbivorous.FindFood()
        {
            Console.WriteLine($"{Name} upolowal korzen");
        }
        //jawnie implementujemy metody gdy chcemy dostarczyc rozne implementacje dla metod o tych samych sygnaturach
        void ICarnivorous.FindFood()
        {
            Console.WriteLine($"{Name} upolowal padline");
        }
    }
}
