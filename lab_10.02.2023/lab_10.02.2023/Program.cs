using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyProject;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix= new Matrix(5, 2);
            matrix.RandMatrix(-20, 20);
            Console.WriteLine(matrix);
            Console.WriteLine(matrix[0, 0]);
        }
    }
}
