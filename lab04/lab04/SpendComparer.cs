using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lab04
{
    class SpendComparer : IComparer<Human>
    {
        public int Compare(Human x, Human y)
        {
            double spendX = 0;
            double spendY = 0;

            foreach (House h in x.houses) spendX += h.Price;
            foreach (House h in y.houses) spendY += h.Price;
            foreach (Car c in x.cars) spendX += c.Price;
            foreach (Car c in y.cars) spendY += c.Price;

            return spendX.CompareTo(spendY);
        }
    }
}
