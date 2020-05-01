using System;
using System.Collections.Generic;
using System.Text;

namespace lab03
{
    class Management
    {
        public List<Document> MyDocuments { get; set; }

        public Management()
        {
            MyDocuments = new List<Document>();
        }

        public void AddDocument(Document doc)
        {
            if (MyDocuments.Exists(d => d.ISBN.Equals(doc.ISBN)))
            {
                throw new AddException($"Document about ISBN {doc.ISBN} already exists");
            }
            else if (doc is Tom)
            {
                Tom tom = (Tom)MyDocuments.Find(t => t.Title.Equals(((Tom)doc).Title));
                if (tom != null)
                {
                    if (tom.TomNumber == ((Tom)doc).TomNumber)
                    {

                        throw new TomExsistException($"Tome number {tom.TomNumber} about title {tom.Title} already exists ");
                    }
                    else if (tom.TomNumber > ((Tom)tom).NumberOfAllToms)
                    {

                        throw new TomNumberException($"Tome number provided {tom.TomNumber} out of range {tom.NumberOfAllToms}");
                    }
                }
            }
            else if(doc.Year < 1450)
            {
                throw new YearException($"In year {doc.Year} printing has not yet been invented" );
            }
            MyDocuments.Add(doc);
        }

        public bool RemoveDocument(String ISBN)
        {
            foreach(Document d in MyDocuments)
            {
                if (d.ISBN.Equals(ISBN))
                {
                    MyDocuments.Remove(d);
                    return true;
                }
            }
            return false;
        }
        public Document GetDocument(String ISBN)
        {
            foreach (Document d in MyDocuments)
            {
                if (d.ISBN.Equals(ISBN))
                {
                    return d;
                }
            }
            return null;
        }
        public List<Document> GetDocuments(String phrase)
        {
            List<Document> result = new List<Document>();
            foreach (Document d in MyDocuments)
            {
                if (d.Title.Contains(phrase))
                {
                    result.Add(d);
                }
            }
            return result;
        }

        public List<Magazine> GetMagazines(Magazine.frequency frequency)
        {
            List<Magazine> result = new List<Magazine>();
            foreach (Document d in MyDocuments)
            {
                if (d is Magazine && ((Magazine)d).Frequency == frequency)
                {
                    result.Add((Magazine) d);
                }
            }
            return result;
        }
        public List<Tom> GetToms(String phrase)
        {
            List<Tom> result = new List<Tom>();
            foreach (Document d in MyDocuments)
            {
                if (d.Title.Contains(phrase))
                {
                    result.Add((Tom) d);
                }
            }
            return result;
        }


    }
}
