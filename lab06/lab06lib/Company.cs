using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06lib
{
    public delegate void Delegate(Employee employee);

    public delegate bool DelegateBool(Employee employee);

    public delegate int DelegateSort(Employee arg1, Employee arg2);

    public delegate String DelegateShow(Employee employee);

    public class Company
    {
        private List<Employee> employees;
        
        public event Delegate OnAdded;
        public event Delegate OnRemoved;
        public Company()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
            OnAdded(e);
        }
        public void RemoveEmployee(int id)
        {
            var temp = employees.FirstOrDefault(x => x.ID == id);
            employees.Remove(temp);
            OnRemoved(temp);
        }

        public void EverybodyDo(Delegate delegat) => employees.ForEach(e => delegat(e));
        public void EverybodyShow(DelegateShow delegat) => employees.ForEach(e => Console.WriteLine(delegat(e)));

        public Employee SearchEmployee(int id) => employees.Find(e => e.ID == id);

        public List<Employee> SearchEmployees(String phrase) => employees.FindAll(e =>  e.Name.Contains(phrase) || e.Surname.Contains(phrase));
        
        public List<Employee> SearchEmployees() => employees.FindAll(e =>  e.NumberOfSales>=10 && e.NumberOfSales <= 200);

        public List<Employee> SearchEmployeesByPractice() => employees.OrderByDescending(e => e.Practice).Take(3).ToList();

        public List<Employee> SearchEmployees(DelegateBool delegat)
        {
            List<Employee> temp = new List<Employee>();
            foreach(var e in employees)
            {
                if (delegat(e))
                {
                    temp.Add(e);
                }
            }
            return temp;
        }

        public List<Employee> SortEmployees(DelegateSort delegat)
        {
            List<Employee> temp = new List<Employee>();
            employees.ForEach(e => temp.Add(e));
            for (int j = 0; j < employees.Count - 1; j++)
            {
                for (int i = 0; i < employees.Count - j - 1; i++)
                {
                    if (delegat(employees[i], employees[i+1]) > 0)
                    {
                        Swap(i, i+1, ref temp);
                    }
                    
                }
            }
            return temp;
        }
        public void Swap<T>(int arg1, int arg2,ref List<T>  employees)
        {
            T temp = employees[arg1];
            employees[arg1] = employees[arg2];
            employees[arg2] = temp;
        }
    }
}
