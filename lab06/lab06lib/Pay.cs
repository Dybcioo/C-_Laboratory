using System;
using System.Collections.Generic;
using System.Text;

namespace lab06lib
{
    public static class Pay
    {
        public static void Rise(Employee employee)
        {
            if (employee.NumberOfSales > 10)
            {
                employee.Salary += 200;
                Console.WriteLine($"{employee.Name} {employee.Surname} podwyzka o 200");
            }
        }

        public static void RisePercent(Employee employee)
        {
            if (employee.Practice > 2)
            {
                employee.Salary += employee.Salary * 0.1;
                Console.WriteLine($"{employee.Name} {employee.Surname} podwyzka o 10%");
            }
        }

        public static void ResetSales(Employee employee)
        {
            employee.NumberOfSales = 0;
            Console.WriteLine($"{employee.Name} {employee.Surname} wyzerowana sprzedaz");
        }

    }
}
