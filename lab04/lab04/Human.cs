using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lab04
{
    class Human : Animal, IEnumerable, ICloneable, IComparable<Human>
    {
        public int IQ { get; set; }
        public List<Car> cars = new List<Car>();
        public List<House> houses = new List<House>();

        public Human(int iQ, int speed, string name, double height) :
            base(speed, name, height)
        {
            IQ = iQ;
        }
        public Human() { }

        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        public IEnumerable GetHouses(int value = 0)
        {
            foreach (House h in houses)
            {
                if (h.Price > value)
                {
                    yield return h;
                }
            }

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override void Growth()
        {
            Height += Height * 0.5;
        }

        public override string ToString()
        {
            return $"IQ: {IQ}, Samochody: {cars}, Domy: {houses}, Szybkosc: {Speed}, Imie: {Name}, Wysokosc: {Height}";
        }

        public int CompareTo(Human obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            return IQ.CompareTo(obj.IQ);
        }

        public static  int Compare(IComparer<Human> comparer, Human x, Human y)
        {
            return comparer.Compare(x, y);
        }
    }
}
