using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human() : this("Human", 0) { }
        public Human(string name) { Name = name; }
        public Human(string name, int age) : this(name)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\t Age: {Age}";
        }
    }
}
