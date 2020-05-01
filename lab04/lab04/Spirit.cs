using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Spirit : Being
    {
        private int transparency;

        public int Transparency
        {
            get { return transparency; }
            set 
            {
                if(value >= 0 && value <= 100)
                {
                    transparency = value;
                }
                else
                {
                    throw new  TransparencyException($"Zla wartosc przezroczystosci: {value} poza przedzialem 0 - 100");
                }
                
            }
        }

        public int AmountOfEctoplasm { get; set; }

        public Spirit(int transparency, int amountOfEctoplasm, string name, double height) :
            base(name, height)
        {
            Transparency = transparency;
            AmountOfEctoplasm = amountOfEctoplasm;
        }

        public Spirit() { }

        public void Scary()
        {
            Console.WriteLine("Buuuu");
        }
    }
}
