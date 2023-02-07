using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(2,4,8);
            Vector vector2 = new Vector(2, 4, 8);

            Console.WriteLine(vector);
            Console.WriteLine("Vector Length:  {0:F2}", vector.GetLength());
            Console.WriteLine(vector.Angle(vector2));
        }
    }
}
