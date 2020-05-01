using System;
using System.Collections.Generic;

namespace lab03
{
    class Program
    {
        Management management = new Management();


        public void AddDoc()
        {
            try
            {
                Book book = new Book("Roberta Ludluma", "978-83-01-00000-1", "Krucjata Bourne’a", 1986, 560);
                Tom tom1 = new Tom(1, 3, "Sienkiewicz", "935-87-11-00000-1", "Ogniem i mieczem", 1902, 300);
                Tom tom2 = new Tom(2, 3, "Sienkiewicz", "935-87-11-00000-2", "Ogniem i mieczem", 1902, 260);
                Magazine magazine = new Magazine(2, Magazine.frequency.monthly, "521-21-05-00000-9", "Top Gear", 2005, 63);
                management.AddDocument(book);
                management.AddDocument(tom1);
                management.AddDocument(tom2);
                management.AddDocument(magazine);
            }
            catch (Exception e)
            {
                ShowExceptions.information(e);

            }

        }
        public void TestException()
        {
            try
            {
                Book book = new Book("Roberta Ludluma", "978-83-01-00000-1", "Krucjata Bourne’a", 1333, 560);
                Tom tom1 = new Tom(1, 3, "Sienkiewicz", "935-87-11-00000-1", "Ogniem i mieczem", 1902, 300);
                Tom tom2 = new Tom(2, 3, "Sienkiewicz", "935-87-11-00000-2", "Ogniem i mieczem", 1902, 260);
                Magazine magazine = new Magazine(2, Magazine.frequency.monthly, "521-21-05-00000-9", "Top Gear", 2005, 63);
                management.AddDocument(book);
                management.AddDocument(tom1);
                management.AddDocument(tom2);
                management.AddDocument(magazine);
            }
            catch (AddException e)
            {
                ShowExceptions.information(e);
            }
            catch (TomExsistException e)
            {
                ShowExceptions.information(e);
            }
            catch (TomNumberException e)
            {
                ShowExceptions.information(e);

            }
            catch (YearException e)
            {
                ShowExceptions.information(e);
            }

        }

        public void ShowDocuments()
        {
            foreach (Document d in management.MyDocuments)
            {
                Console.WriteLine("======================");
                Console.WriteLine(d);
            }
        }
        static void Main(string[] args)
        {
            int switchCase;
            Program program = new Program();


            while (true)
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1. Add documents");
                Console.WriteLine("2. Show documents");
                Console.WriteLine("3. Search by ISBN");
                Console.WriteLine("4. Search by phrase");
                Console.WriteLine("5. Search magazine by frequency");
                Console.WriteLine("6. Search Tom by Title");
                Console.WriteLine("7. Test Exception");
                Console.Write("What to do? ");
                switchCase = int.Parse(Console.ReadLine());



                switch (switchCase)
                {
                    case 1:
                        Console.Clear();
                        program.AddDoc();
                        Console.WriteLine("Documents added");
                        break;
                    case 2:
                        Console.Clear();
                        program.ShowDocuments();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.WriteLine(program.management.GetDocument(isbn));

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter phrase: ");
                        string phrase = Console.ReadLine();
                        foreach (Document d in program.management.GetDocuments(phrase))
                        {
                            Console.WriteLine(d);
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("1. Daily");
                        Console.WriteLine("2. Weekly");
                        Console.WriteLine("3. Monthly");
                        Console.WriteLine("4. Yearly");
                        Console.Write("Enter frequency: ");
                        int n = int.Parse(Console.ReadLine());
                        List<Magazine> magazines = new List<Magazine>();
                        switch (n)
                        {
                            case 1:
                                magazines = program.management.GetMagazines(Magazine.frequency.daily);
                                break;
                            case 2:
                                magazines = program.management.GetMagazines(Magazine.frequency.weekly);
                                break;
                            case 3:
                                magazines = program.management.GetMagazines(Magazine.frequency.monthly);
                                break;
                            case 4:
                                magazines = program.management.GetMagazines(Magazine.frequency.yearly);
                                break;
                        }
                            foreach (Magazine m in magazines)
                            {
                                Console.WriteLine(m);
                            }
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        foreach (Tom t in program.management.GetToms(title))
                        {
                            Console.WriteLine(t);
                        }
                        break;
                    case 7:
                        Console.Clear();
                        program.TestException();
                        break;
                }
            }
        }
    }
}
