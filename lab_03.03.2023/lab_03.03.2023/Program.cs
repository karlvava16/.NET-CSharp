using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab
{
    internal class Program
    {
        static void Task1()
        {
            Regex regex = new Regex( @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            string email;

            Console.Write("Enter email: ");
            email = Console.ReadLine();
            if(regex.IsMatch(email))
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is not valid");
            }
        }

        static void Task2()
        {
            Regex regex = new Regex("^\\+?[1-9][0-9]{7,14}$");
            string phNumber;

            Console.Write("Enter phone number: ");
            phNumber = Console.ReadLine();

            if(regex.IsMatch(phNumber))
            {
                Console.WriteLine("Phone number is valid");
            }
            else { Console.WriteLine("Phone number is not valid"); }
        }

        static void Task7()
        {
            Regex regex = new Regex("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");

            string ip;

            Console.WriteLine("Enter ip address: ");
            ip = Console.ReadLine();

            if (regex.IsMatch(ip))
            {
                Console.WriteLine("Ip is valid");
            }
            else
            {
                Console.WriteLine("Ip is not valid");
            }
        }

        static void Task8()
        {
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            int count = Regex.Replace(text, "[^euioayаиёеяюэоы]", "", RegexOptions.IgnoreCase).Length;
            Console.WriteLine("Number of vowels equals " + count);
        }

        static void Task9()
        {
            Regex regex = new Regex("^http(s)?://([\\w-]+.)+[\\w-]+(/[\\w- ./?%&=])?$");
            Console.WriteLine("Enter URL: ");
            string url = Console.ReadLine();
            if(regex.IsMatch(url))
            {
                Console.WriteLine("Url is valid");
            }
            else
            {
                Console.WriteLine("Url is not valid");
            }
        }

        static void Task10()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            if (Regex.IsMatch(text, "^[a-zA-Zа-яА-Я0-9]*$"))
            {
                Console.WriteLine("Alphanumeric String");
            }
            else
            {
                Console.WriteLine("Non-Alphanumeric String");
            }
        }

        static void Task11()
        {
            Console.Write("Enter time: ");
            string time = Console.ReadLine(); // sample time string
            Regex timeRegex = new Regex(@"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$"); // regular expression to match time string

            if (timeRegex.IsMatch(time))
            {
                Console.WriteLine("Time string is valid");
            }
            else
            {
                Console.WriteLine("Time string is not valid");
            }
        }
        

        static void Task12()
        {
            Console.Write("Enter post index: ");
            string input = Console.ReadLine();

            bool isZipCode = Regex.IsMatch(input, @"^\d{5}(?:[-\s]\d{4})?$");
            Console.WriteLine("{0} is a valid US ZIP code: {1}", input, isZipCode);
        }

        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            Task12();
        }
    }
}
