using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract void Print();

        public Worker(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }

    class President : Worker 
    {
        public string Country { get; set; }

        public President (string name,string surname, string country) : base (name, surname)
        {
            Country = country;
        }

        public override void Print()
        {
            Console.WriteLine($"|President|\nName: {Name}\nSurname: {Surname}\nCountry: {Country}");
        }
    }

    class Security : Worker
    {
        public string SecureObject { get; set; }

        public Security(string name, string surname, string secureObject) : base(name, surname)
        {
            SecureObject = secureObject;
        }

        public override void Print()
        {
            Console.WriteLine($"|Security|\nName: {Name}\nSurname: {Surname}\nSecure Object: {SecureObject}");
        }
    }
    
    class Manager : Worker
    {
        public string Firm { get; set; }

        public Manager(string name, string surname, string firm) : base(name, surname)
        {
            Firm = firm;
        }

        public override void Print()
        {
            Console.WriteLine($"|Manager|\nName: {Name}\nSurname: {Surname}\nFirm: {Firm}");
        }
    }

    class Engineer : Worker
    {
        public string Factory { get; set; }

        public Engineer(string name, string surname, string factory) : base(name, surname)
        {
            Factory = factory;
        }

        public override void Print()
        {
            Console.WriteLine($"|Engineer|\nName: {Name}\nSurname: {Surname}\nFactory: {Factory}");
        }
    }
}
