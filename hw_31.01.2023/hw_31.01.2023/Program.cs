using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_31._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FirstTask();
            //SecondTask();
            //ThirdTask();
            //FourthTask();
            //FifthTask();
            //SixTask();
            SevenTask();
        }

        static void FirstTask()
        {
            int value;
            Console.WriteLine("Enter value  in range 1 - 100 : ");
            value = Convert.ToInt32(Console.ReadLine());

            if(value >= 1 && value <= 100) 
            {
                if(value % 5 == 0 && value % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (value % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (value % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(value);
                }
            }
            else
            {
                Console.WriteLine("Out of range 1 - 100.");
            }
        }

        static void SecondTask()
        {
            double value;
            double percent;

            Console.WriteLine("Enter value : ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter percent : ");
            percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result = " + value * percent / 100 + "\n");
        }

        static void ThirdTask()
        {
            int value;
            string temp = "";
            Console.WriteLine("Enter 4 value : ");
            for (int i = 0; i < 4; i++)
            {
                value = Convert.ToInt32(Console.ReadLine());
                if (value >= 0 && value <= 9)
                {
                    temp = temp + Convert.ToString(value);
                }
                else
                {
                    i--;
                }
            }

            value = Convert.ToInt32(temp);
            Console.WriteLine(value + "\n");
        }

        static void FourthTask()
        {
            int value;
            string temp;

            int firstD, secondD;

            Console.Write("Enter 6 digit value : ");
            temp = Console.ReadLine();
            value = Convert.ToInt32(temp);

            if (!(value > 99999 && value < 1000000))
            {
                Console.WriteLine("Is not six digit value");
                return;
            }

            Console.Write("Enter first digit (1-6) : ");
            firstD = Convert.ToInt32(Console.ReadLine());
            if (!(firstD >= 1 && firstD <= 6))
            {
                Console.WriteLine($"There is no {firstD} digit value");
                return;
            }

            Console.Write("Enter first digit (1-6) : ");
            secondD = Convert.ToInt32(Console.ReadLine());
            if (!(secondD >= 1 && secondD <= 6))
            {
                Console.WriteLine($"There is no {secondD} digit value");
                return;
            }
            Console.WriteLine(temp);


            char[] temp3 = temp.ToCharArray();
            char temp2 = temp3[firstD - 1];
            temp3[firstD - 1] = temp3[secondD - 1];
            temp3[secondD - 1] = temp2;

            Console.WriteLine(temp3);
        }

        static void FifthTask()
        {
            int day, month, year;
            Console.Write("Enter day : ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month : ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year : ");
            year = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            if(date.Month  == 1 || date.Month == 2 || date.Month == 12)
            {
                Console.Write("Winter ");
            }
            else if (date.Month >= 3 && date.Month <= 5)
            {
                Console.Write("Spring ");
            }
            else if (date.Month >= 3 && date.Month <= 5)
            {
                Console.Write("Summer ");
            }
            else
            {
                Console.Write("Autum ");
            }

            Console.WriteLine(date.ToString("dddd"));

        }

        static void SixTask()
        {
            double temp, result;
            bool type;
            Console.Write("Enter temperature type (Fahrenheit - true, Celsius - false) : ");
            type = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter temperature : ");
            temp = Convert.ToDouble(Console.ReadLine());
            if(type)
            {
                result = (temp - 32) * 5 / 9;
            }
            else
            {
                result = (temp * 9) / 5 + 32;
            }
            Console.WriteLine($"Result: {result}");
        }

        static void SevenTask()
        {
            int firstR, secondR;
            Console.Write("Enter first range: ");
            firstR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second range: ");
            secondR = Convert.ToInt32(Console.ReadLine());
            if(firstR > secondR)
            {
                (firstR, secondR) = (secondR, firstR);
            }
            for (int i = firstR; i <= secondR; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
