using System;
using System.Collections.Generic;
using System.Text;

namespace lab03
{
    class Tom : Book
    {
        public int TomNumber { get; set; }
        public int NumberOfAllToms { get; set; }

        public Tom(int tomNumber, int numberOfAllToms, string author, string ISBN, string title, int year, int pageNumber)
            : base(author, ISBN, title, year, pageNumber)
        {
            TomNumber = tomNumber;
            NumberOfAllToms = numberOfAllToms;
        }

        public Tom()
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"Tom number: {TomNumber}; Number of all toms: {NumberOfAllToms}";
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
