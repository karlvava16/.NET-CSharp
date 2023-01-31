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
            //ThirdTask();
            //FourthTask();
            //FifthTask();
            SixTask();
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
            int value;
            Console.WriteLine("Enter 6 digit value : ");
            value = Convert.ToInt32(Console.ReadLine());
            if(value > 99999 && value < 100000)
            {
                Console.WriteLine("Is not 6 digit value");
            }
            else
            {
                string temp = Convert.ToString(value);
                string temp2 = "";
                for (int i = temp.Length - 1; i >= 0; i--)
                {
                    temp2 += temp[i];
                }

                Console.WriteLine(temp2 + "\n\n");
            }
        }

        static void FourthTask()
        {
            int firstV = 0;
            int secondV = 1;
            int currentV = 0;
            int firstR, secondR;
            Console.Write("Enter first range : ");
            firstR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second range : ");
            secondR = Convert.ToInt32(Console.ReadLine());
            if(firstR == 0)
            {
                Console.Write(firstV + " ");
            }
            if (firstR <= 1)
            {
                Console.Write(secondV + " ");
            }
            while(currentV <= secondR)
            {
                currentV = firstV + secondV;
                if(currentV >= firstR && currentV <= secondR)
                {
                    Console.Write(currentV + " ");
                }
                firstV = secondV;
                secondV = currentV;
            }
            Console.Write("\n\n");
        }

        static void FifthTask()
        {
            int firstR, secondR;
            Console.Write("Enter first range : ");
            firstR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second range : ");
            secondR = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            for (int i = firstR; i <= secondR; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");
        }

        static void SixTask()
        {
            int lineLength;
            char symbol;
            bool pos;

            Console.Write("Enter line length : ");
            lineLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter symbol : ");
            symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter pos (false - vertical, true - horizontal) : ");
            pos = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\n");

            if (pos)
            {
                for (int i = 0; i < lineLength; i++)
                {
                    Console.Write(symbol);
                }
                Console.Write("\n");
            }
            else
            {
                for (int i = 0; i < lineLength; i++)
                {
                    Console.Write(symbol);
                    Console.Write("\n");
                }
            }
            Console.Write("\n");

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
