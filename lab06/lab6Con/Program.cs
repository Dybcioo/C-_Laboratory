using System;
using lab06lib;

namespace lab6Con
{
    class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            c.OnAdded += e => Console.WriteLine($"Dodano pracownika: {e}");
            c.OnRemoved += e => Console.WriteLine($"Usunieto pracownika: {e}");
            c.AddEmployee(new Employee(1, "aaa", "bbb", 3, 14, 2300));
            c.AddEmployee(new Employee(2, "ccc", "aba", 1, 10, 2000));
            c.AddEmployee(new Employee(3, "bbb", "ccc", 4, 22, 2000));
            c.AddEmployee(new Employee(4, "fff", "aaa", 13, 9, 2000));
            c.AddEmployee(new Employee(5, "ddd", "eee", 5, 3, 2000));
            Console.WriteLine("=======================================");
            Console.WriteLine("Zwiekszenie pensji o 200");
            c.EverybodyDo(Pay.Rise);
            c.EverybodyDo(e => Console.WriteLine(e));
            Console.WriteLine("Zwiekszenie pensji o procent");
            c.EverybodyDo(Pay.RisePercent);
            c.EverybodyDo(e => Console.WriteLine(e));
            Console.WriteLine("Zerowanie pola sprzedaz");
            c.EverybodyDo(Pay.ResetSales);
            c.EverybodyDo(e => Console.WriteLine(e));
            Console.WriteLine("=======================================");
            Console.WriteLine($"Wyszukany pracownik {c.SearchEmployee(1)}");
            Console.WriteLine("\nSzukanie po frezie 'a'");
            c.SearchEmployees("a").ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\nSzukanie po liczbie sprzedazy");
            c.SearchEmployees().ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\nSzukanie po stazu pracy");
            c.SearchEmployeesByPractice().ForEach(e => Console.WriteLine(e));

            Console.WriteLine("=============================================\n");
            c.EverybodyShow(e => $"Ja jestem {e.Name} moje id to {e.ID} i zarabiam {e.Salary} a Ty studenciku?");
            Console.WriteLine("=============================================\n");
            c.SearchEmployees(e => e.ID < 3).ForEach(e => Console.WriteLine(e));
            Console.WriteLine("=============================================\n");
            c.SortEmployees((e1, e2) => -e1.ID.CompareTo(e2.ID)).ForEach(e => Console.WriteLine(e));
            Console.WriteLine("=============================================\n");
            c.RemoveEmployee(5);
            c.RemoveEmployee(4);
            c.RemoveEmployee(3);
            c.RemoveEmployee(2);
            c.RemoveEmployee(1);



        }

    }
}
