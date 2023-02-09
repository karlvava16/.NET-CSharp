using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Documents;
using Calculations;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passport passport = new Passport("Vlad", "Karlinskyi", "012345678", "Odesa/Ukraine", "M", "Ukraine", "23.01.2004", "30.01.2022", "30.05.2030");
            Console.WriteLine(passport);
            Console.WriteLine("\n\n");
            Comparer comp = new Comparer();
            comp.Expression = "3 >= 5 ";
            Console.WriteLine(comp.Result);
        }
    }
}
