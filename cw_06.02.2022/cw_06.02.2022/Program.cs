using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Ivan", 20);
            Console.WriteLine(a.Name);
        }
    }
}
