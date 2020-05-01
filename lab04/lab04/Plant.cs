using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Plant : Being, IGrowth, IPlants
    {
        public int AmountOx { get; set; }
        public state State { get; set; }

        public enum state 
        {
            growth,
            blooms,
            berry
        }

        public Plant(int amountOx, state state, string name, double height):
            base(name, height)
        {
            AmountOx = amountOx;
            State = state;
        }

        public Plant() { }

        void IGrowth.Growth() => Height += AmountOx * 2;
        void IPlants.Growth() => Height += AmountOx * 1.5;

        public void Blooms() => State = state.blooms;

        public void Berry() => State = state.berry;
    }
}
