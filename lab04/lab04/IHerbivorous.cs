using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{   //Interfejs definiujemy po to zeby stworzyc baze wspolnego kodu dla grupy klas ktore beda go implementowac
    interface IHerbivorous
    {
        public void FindFood();
        public void EatPlant();
    }
}
