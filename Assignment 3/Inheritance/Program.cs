using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Raj", 30000);
            e1.salarycalculation();
            e1.Display();

            Manager e2 = new Manager("Ram", 50000);
            e2.salarycalculation();
            e2.Display();

            MarketingExecutive e3 = new MarketingExecutive("Ajay", 55000, 157);
            e3.salarycalculation();
            e3.Display();
        }
    }
}
