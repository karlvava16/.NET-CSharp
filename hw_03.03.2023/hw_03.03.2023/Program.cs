using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            Task8();
        }

        static void Task1()
        {
            Regex regex = new Regex("a\\Sb");
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            foreach (var r in regex.Matches(str))
            {
                Console.WriteLine(r);
            }

        }

        static void Task2() 
        {
            Regex regex = new Regex("a\\S{2}a");
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            foreach (var r in regex.Matches(str))
            {
                Console.WriteLine(r);
            }
        }

        static void Task3()
        {
            Regex regex = new Regex("a\\S[^e]{1}a");
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            foreach (var r in regex.Matches(str))
            {
                Console.WriteLine(r);
            }
        }

        static void Task4()
        {
            Regex regex = new Regex("ab{1,}a");
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            foreach (var r in regex.Matches(str))
            {
                Console.WriteLine(r);
            }
        }

        static void Task5()
        {
            Regex regex = new Regex("ab{0,}a");
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            foreach (var r in regex.Matches(str))
            {
                Console.WriteLine(r);
            }
        }

        static void Task6()
        {
            Regex regex = new Regex("ab?a");
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            foreach (var r in regex.Matches(str))
            {
                Console.WriteLine(r);
            }
        }
        static void Task7()
        {
            Regex regex = new Regex("ab?a");
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            foreach (var r in regex.Matches(str))
            {
                Console.WriteLine(r);
            }
        }

        static void Task8()
        {
            Regex regex = new Regex("(ab){1,}");
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            foreach (var r in regex.Matches(str))
            {
                Console.WriteLine(r);
            }
        }

    }
}
