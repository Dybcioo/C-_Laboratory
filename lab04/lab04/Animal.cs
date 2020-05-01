using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Animal : Being, IGrowth
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set 
            {
                if (value < 1225)
                {
                    speed = value;
                }
                else
                {
                    throw new SpeedException($"Podana szybkosc {value} jest wieksza od szybkosci swiatla");
                }
            }
        }


        public Animal(int speed, string name, double height):
            base(name, height)
        {
            Speed = speed;
        }

        public Animal() { }

        public virtual void Growth()
        {
            Height += Height * 0.2;
        }

        
    }
}
