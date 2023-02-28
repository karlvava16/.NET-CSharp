using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void MySwap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
        static void Main(string[] args)
        {
            //Task1
            int value1 = 12, value2 = 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            MySwap(ref value1, ref value2);

            Console.WriteLine(value1);
            Console.WriteLine(value2);


        }
    }
}
