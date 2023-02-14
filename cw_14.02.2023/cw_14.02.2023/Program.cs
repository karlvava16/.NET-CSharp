using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Classwork
            IMove[] move = new IMove[4];
            move[0] = new Camel("Camel", 15);
            move[1] = new Student("Vlad", 19, "IT Step");
            move[2] = new Teacher("Vlad", 19, "IT Step");
            move[3] = new Airplane("Boing", 200);

            foreach (var i in move)
            {
                i.Move();
            }

            //Task3
            MyArray array = new MyArray(20);
            array.Rand(-20, 20);
            array.Show();
            Console.WriteLine();

            array.SortDesc();
            array.Show();
            Console.WriteLine();

            Console.WriteLine(array.CountDistinct());

        }
    }
}
