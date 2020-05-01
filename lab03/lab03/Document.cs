using System;
using System.Collections.Generic;
using System.Text;

namespace lab03
{
    abstract class Document
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int PageNumber { get; set; }

        protected Document(string iSBN, string title, int year, int pageNumber)
        {
            ISBN = iSBN;
            this.Title = title;
            this.Year = year;
            this.PageNumber = pageNumber;
        }

        protected Document()
        {
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}; Title: {Title} ; Year: {Year}; Number of page: {PageNumber};";
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
