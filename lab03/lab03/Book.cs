using System;
using System.Collections.Generic;
using System.Text;

namespace lab03
{

    class Book : Document
    {
        public string Author { get; set; }

        public Book(string author, string ISBN, string title, int year, int pageNumber) 
            : base(ISBN, title, year, pageNumber )
        {
            Author = author;
        }

        public Book()
        {
        }

        public override string ToString()
        {
            return base.ToString()+ $"Author: {Author};";
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
