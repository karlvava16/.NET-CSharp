using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace Classwork
{
    abstract class Transport : IMove
    {
        public string Name { get; set; }

        public int Speed { get; set; }

        public Transport(string name, int speed)
        {
            Name = name; Speed = speed;
        }

        public abstract void Move();
        public abstract void Print();
    }

    class Camel : Transport
    {
        public Camel(string name, int speed) : base(name, speed) { }

        public override void Move()
        {
            Console.WriteLine("Move Camel");
        }

        public override void Print()
        {
            Console.WriteLine("Print Camel");
        }
    }


    class Airplane : Transport
    {
        public Airplane(string name, int speed) : base(name, speed) { }

        public override void Move()
        {
            Console.WriteLine("Move Airplane");
        }

        public override void Print()
        {
            Console.WriteLine("Print Airplane");
        }
    }
}
