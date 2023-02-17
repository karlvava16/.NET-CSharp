using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        public delegate void MyDel1(string UserName);
        public delegate double MyDel2(double first, double second);
        static void Main(string[] args)
        {
            Console.WriteLine("|Task1|");
            FirstTask ft = new FirstTask();
            MyDel1 del1 = new MyDel1(ft.FirstMethod);
            del1.Invoke("Vlad");
            del1 = ft.SecondMethod;
            del1.Invoke("Vlad");
            del1 = ft.ThirdMethod;
            del1.Invoke("Vlad");
            Console.WriteLine("\n");

            Console.WriteLine("|Task2|");
            int firstV, secondV;
            char oper;

            Console.Write("Enter first value : ");
            firstV = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second value : ");
            secondV = Convert.ToInt32(Console.ReadLine());


            MyDel2 del2 = new MyDel2(Calc.Sum);
            del2 += Calc.Sub;
            del2 += Calc.Mult;
            del2 += Calc.Dev;

            Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", del2.GetInvocationList()[0], del2.GetInvocationList()[1], del2.GetInvocationList()[2], del2.GetInvocationList()[3]);


            Console.WriteLine("|Task3|");


            Console.WriteLine("|Task4|");

            Console.Write("Enter operation (+,-,/,*) : ");
            oper = Convert.ToChar(Console.ReadLine());
            MyDel2 del4;


            switch (oper)
            {
                case '+':
                    del4 = new MyDel2(Calc.Sum);
                    break;
                case '-':
                    del4 = new MyDel2(Calc.Sub);
                    break;
                case '*':
                    del4 = new MyDel2(Calc.Mult);
                    break;
                case '/':
                    del4 = new MyDel2(Calc.Dev);
                    break;
                default:
                    throw new Exception("Invalid operation");
            }

            Console.WriteLine(firstV + " " + oper + " " + secondV + " = " + del2(firstV, secondV) + "\n");

        }
    }
}
