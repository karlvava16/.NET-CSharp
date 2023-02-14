using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace Classwork
{
    abstract class Human : IMove
    {
        string name;
        public int Age { get; set; }
        public string Name { get { return name; } set { name = value; } }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Move();

        public abstract void Print();
    }

    class Student : Human
    {
        public string Academy { get; set; }
        public Student(string name, int age, string academy) : base(name, age) { Academy = academy; }

        public override void Move()
        {
            Console.WriteLine("Move Student");
        }

        public override void Print()
        {
            Console.WriteLine("Print Student");
        }
    }

    class Teacher : Human
    {
        public string Academy { get; set; }
        public Teacher(string name, int age, string academy) : base(name, age) { Academy = academy; }

        public override void Move()
        {
            Console.WriteLine("Move Teacher");
        }

        public override void Print()
        {
            Console.WriteLine("Print Teacher");
        }
    }

}
