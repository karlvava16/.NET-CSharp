using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calc();
            //FirstTask();
            //SecondTask();
            ThirdTask();
            //hello
        }

        static void FirstTask()
        {
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup\n\n");
        }

        static void SecondTask()
        {
            int firstV, secondV, thirdV, fourthV, fifthV;
            int max, min, sum, mult;
            Console.WriteLine("Enter 5 values: ");
            firstV = Convert.ToInt32(Console.ReadLine());
            secondV = Convert.ToInt32(Console.ReadLine());
            thirdV = Convert.ToInt32(Console.ReadLine());
            fourthV = Convert.ToInt32(Console.ReadLine());
            fifthV = Convert.ToInt32(Console.ReadLine());

            sum = firstV+ secondV + thirdV + fourthV + fifthV;
            mult = firstV * secondV * thirdV * fourthV * fifthV;

            max = firstV;
            if (secondV > max)
                max = secondV;
            if (thirdV > max)
                max = thirdV;
            if (fourthV > max)
                max = fourthV;
            if (fifthV > max)
                max = fifthV;

            min = firstV;
            if (secondV < min)
                min = secondV;
            if (thirdV < min)
                min = thirdV;
            if (fourthV < min)
                min = fourthV;
            if (fifthV < min)
                min = fifthV;

            Console.WriteLine($"Max : {max}");
            Console.WriteLine($"Min : {min}");
            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Mult : {mult}\n\n");

        }


        static void ThirdTask()
        {

        }

        

        

        static void Calc()
        {
            double firstValue, secondValue, result = 0;
            char operation;
            Console.Write("Введите первое значение : ");
            firstValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе значение : ");
            secondValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию (+, -, *, /) : ");
            operation = Convert.ToChar(Console.ReadLine());

            if (operation == '/' && secondValue == 0)
            {
                Console.WriteLine("Делить на ноль нельзя\n\n");
            }
            else
            {
                switch (operation)
                {
                    case '+':
                        result = firstValue + secondValue;
                        break;
                    case '-':
                        result = firstValue - secondValue;
                        break;
                    case '*':
                        result = firstValue * secondValue;
                        break;
                    case '/':
                        result = firstValue / secondValue;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"{firstValue} {operation} {secondValue} = {result}\n\n");

            }
        }
    }
}
