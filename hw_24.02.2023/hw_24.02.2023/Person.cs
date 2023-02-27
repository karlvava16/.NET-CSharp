using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsPerson
{
    class Person
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Sex { get; set; }
        string PlaceOfResidence { get; set; }
        string passportNumber;
        public string PassportNumber
        {
            get { return passportNumber; }
            set
            {
                if (value.Length != 9)
                    throw new ArgumentException("Inccorect passport number length");

                foreach (char c in value)
                {
                    if (!(c >= '0' && c <= '9'))
                    {
                        throw new ArgumentException("Unacceptable character \"" + c + "\"");
                    }
                }
                passportNumber = value;
            }
        }

        public Person() { }
        public Person(string name) { Name = name; }
        public Person(string name, string surname) : this(name) { Surname = surname; }
        public Person(string name, string surname, string sex) : this(name, surname) { Sex = sex; }
        public Person(string name, string surname, string sex, string passportN) : this(name, surname, sex) { PassportNumber = passportN; }
        public Person(string name, string surname, string sex, string passportN, string pofr) : this(name, surname, sex, passportN) { PlaceOfResidence = pofr; }

    }

    class Student : Person
    {
        string Group { get; set; }
        Person[] Parants { get; set;}

        public Student() { }
        public Student(string name) :base(name) { }
        public Student(string name, string surname) : base(name, surname) { }
        public Student(string name, string surname, string sex) : base(name, surname, sex) { }
        public Student(string name, string surname, string sex, string passportN, string pofr) : base(name, surname, sex, passportN, pofr) { }
        public Student(string name, string surname, string sex, string passportN, string pofr, string group) : base(name, surname, sex, passportN, pofr) { Group = group; }
        public Student(string name, string surname, string sex, string passportN, string pofr, string group, Person[] parants) : this(name, surname, sex, passportN, pofr, group) { Parants = parants; }
    }
}
