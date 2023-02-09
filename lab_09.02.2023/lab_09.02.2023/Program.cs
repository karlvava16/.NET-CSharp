using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bank;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Vlad", "Karlisnkyi", "23.01.2004", "+38096904354", "vladkarl@gmail.com", "developer", "c++ programming, c# programming", 1000);
            Console.WriteLine(emp);
        }
    }
}
