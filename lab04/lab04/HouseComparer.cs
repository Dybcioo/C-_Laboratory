using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lab04
{
    class HouseComparer : IComparer<Human>
    {
        public int Compare( Human x,  Human y)
        {
            return x.houses.Count.CompareTo(y.houses.Count);
        }
    }
}
