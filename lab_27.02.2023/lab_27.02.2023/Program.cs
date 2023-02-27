using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Test<T> where T: IComparable<T>
    {
       public T a { get; set; }
        public Test(T a)
        {
            this.a = a;
        }               
        public static bool operator >(Test<T> obj1, Test<T> obj2)
        {

            return obj1.a.CompareTo(obj2.a) > 0;
        }
        public static bool operator <(Test<T> obj1, Test<T> obj2)
        {
            return obj1.a.CompareTo(obj2.a) < 0;
        }
        public static Test<T> Max(Test<T> a, Test<T> b)
        {
            if(a>b)
            {
                return a;
            }
            return b;
        }

        public static Test<T> Min(Test<T> a, Test<T> b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }

        public override string ToString()
        {
            return a.ToString();
        }
    }

    class Program
    {
        public static T MySum<T>(T[] array) where T : struct
        {
            T sum = default(T);
            foreach (T item in array)
                sum = (dynamic)sum + item;
            return sum;
        }

        static void Main(string[] args)
        {

            Test<int> a= new Test<int>(100);
            Test<int> b = new Test<int>(20);
            Test<int> c = new Test<int>(250);


            // Task1
            Test<int> MAX = Test<int>.Max(Test<int>.Max(a, b), c);
            Console.WriteLine(MAX);
            Console.WriteLine();

            // Task2
            Test<int> MIN = Test<int>.Min(Test<int>.Min(a, b), c);
            Console.WriteLine(MIN);
            Console.WriteLine();

            // Task3
            double[] array = { 2.5, 2.5, 2.5, 2.5, 2.5 };
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.WriteLine("Sum: " + MySum(array) + "\n");


            //Task4

        }
    }
}
