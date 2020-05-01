using System;
using System.Collections.Generic;
using System.Text;

namespace lab03
{
    class Magazine : Document
    {
        public int Number { get; set; }
        public enum frequency 
        { 
            daily,
            weekly,
            monthly,
            yearly
        }
        public frequency Frequency { get; set; }

        public Magazine(int number, frequency frequency, string ISBN, string title, int year, int pageNumber)
            :base( ISBN, title, year, pageNumber)
        {
            Number = number;
            Frequency = frequency;
        }

        public Magazine()
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"Number: {Number}; Frequency: {Frequency}";
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
