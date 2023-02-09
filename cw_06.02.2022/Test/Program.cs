using MyProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TaskCw();
            //Task4();
            //Task5();
            //Task6();
            Task7();
        }

        static void TaskCw()
        {
            Student student = new Student("Igor", 20);
            Console.WriteLine(student);
        }

        static void Task4()
        {
            City city = new City("Odesa", "Ukraine", "048", 2000000, new string[] {"Primorskyi" , "Kievskiy", "Suvorovskiy", "Tairova"});
            Console.WriteLine(city);
        }

        static void Task5() 
        {
            Employee emp = new Employee("Vlad", "Karlisnkyi", "23.01.2004", "+38096904354", "vladkarl@gmail.com", "developer", "c++ programming\n c# programming");
            Console.WriteLine(emp);
        }

        static void Task6()
        {
            Plain plain = new Plain("Keyo", "boing", "2004", "boing");
            Console.WriteLine(plain);
        }

        static void Task7()
        {
            Matrix matrix = new Matrix(4,4);
            matrix.RandMatrix(-20, 20);
            Matrix matrix2 = new Matrix(4, 4);
            matrix2.RandMatrix(-20, 20);
            Console.WriteLine(matrix);
            Console.WriteLine(matrix2);

        }
    }
}
