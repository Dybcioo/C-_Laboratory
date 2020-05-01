using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lab04
{
    class CarComparer : IComparer<Human>
    {
        public int Compare( Human x, Human y)
        {
            return x.cars.Count.CompareTo(y.cars.Count);
        }
    }
}
