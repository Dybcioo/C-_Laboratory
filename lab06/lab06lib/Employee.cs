using System;
using System.Collections.Generic;
using System.Text;

namespace lab06lib
{
    public class Employee
    {
        public int ID { get; set; } = 1;
        public string Name { get; set; } = "Jan";
        public string Surname { get; set; } = "Kowalski";
        public int Practice { get; set; } = 2;
        public int NumberOfSales { get; set; } = 80;
        public double Salary { get; set; } = 2300;

        public Employee(int iD, string name, string surname, int practice, int numberOfSales, double salary)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Practice = practice;
            NumberOfSales = numberOfSales;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {ID}; Name: {Name}; Surname: {Surname}; Practice: {Practice}; NumberOfSales: {NumberOfSales}; Salary: {Salary}";
        }
    }
}
