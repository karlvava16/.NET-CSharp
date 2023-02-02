using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace hw_01._02._2023
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
            //SixthTask();
            SeventhTask();

        }

        static void FirstTask()
        {
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            Random rand = new Random();
            int min, max;
            int mult = 1, sum = 0;
            int sumOddA = 0, sumOddB = 0;


            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.Next(1, 10);
                    Console.Write("{0}\t", B[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter 5 variables : ");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < A.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    sumOddA += A[i];
                }
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        sumOddB += B[i, j];
                    }
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                mult *= A[i];
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sum += B[i, j];
                    mult *= B[i, j];
                }
            }

            Console.WriteLine("Sum : {0}", sum);
            Console.WriteLine("Mult : {0}", mult);
            Console.WriteLine("SumOddA : {0}", sumOddA);
            Console.WriteLine("SumOddB : {0}", sumOddB);

        }

        static void SecondTask()
        {
            Random rand = new Random();
            int[,] array = new int[5, 5];
            int[] min = new int[2];
            int[] max = new int[2];

            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[min[0], min[1]] > array[i, j])
                    {
                        min[0] = i; min[1] = j;
                    }
                    if (array[max[0], max[1]] < array[i, j])
                    {
                        max[0] = i; max[1] = j;
                    }
                }
            }

            int first = min[0] * array.GetLength(1) + min[1];
            int second = max[0] * array.GetLength(1) + max[1];

            if (first > second)
            {
                (first, second) = (second, first);
            }


            for (int i = first + 1; i < second; i++)
            {
                sum += array[i / array.GetLength(0), i % array.GetLength(1)];
            }


            Console.WriteLine("Min : {0}\nMax : {1}", array[min[0], min[1]], array[max[0], max[1]]);
            Console.WriteLine("Sum : {0}", sum);

        }

        static void ThirdTask()
        {
            string str;
            string result = "";
            int shift;
            Console.WriteLine("Enter string : ");
            str = Console.ReadLine();
            Console.Write("Enter shift : ");
            shift = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    if (Convert.ToChar(str[i] + shift) > 'z')
                    {
                        result += Convert.ToChar('a' + (str[i] + shift - 'z' - 1));
                    }
                    else
                    {
                        result += Convert.ToChar(str[i] + shift);
                    }
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    if (Convert.ToChar(str[i] + shift) > 'Z')
                    {
                        result += Convert.ToChar('A' + (str[i] + shift - 'Z' - 1));
                    }
                    else
                    {
                        result += Convert.ToChar(str[i] + shift);
                    }
                }
                else if (str[i] >= 'а' && str[i] <= 'я')
                {
                    if (Convert.ToChar(str[i] + shift) > 'я')
                    {
                        result += Convert.ToChar('а' + (str[i] + shift - 'я' - 1));
                    }
                    else
                    {
                        result += Convert.ToChar(str[i] + shift);
                    }
                }
                else if (str[i] >= 'А' && str[i] <= 'Я')
                {
                    if (Convert.ToChar(str[i] + shift) > 'Я')
                    {
                        result += Convert.ToChar('А' + (str[i] + shift - 'Я' - 1));
                    }
                    else
                    {
                        result += Convert.ToChar(str[i] + shift);
                    }
                }
                else
                {
                    result += str[i];
                }

            }
            str = result;
            Console.WriteLine(str);

        }

        static void FourthTask()
        {
            Random rand = new Random();
            int[,] matrix = new int[rand.Next(2, 6), rand.Next(2, 6)];
            int value;
            char operation;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-10, 10);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.Write("Enter value : ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operation (+, *) : ");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] += value;
                        }
                    }
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write("{0}\t", matrix[i, j]);
                        }
                        Console.WriteLine("\n");
                    }
                    break;
                case '*':
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] *= value;
                        }
                    }
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write("{0}\t", matrix[i, j]);
                        }
                        Console.WriteLine("\n");
                    }
                    break;
            }
        }

        static void FifthTask()
        {
            string str;
            string firstVariable = "";
            string secondVariable = "";
            char operation = ' ';
            int result = 0;

            str = Console.ReadLine();

            int i = 0;

            for (; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    for (; i < str.Length; i++)
                    {
                        if (str[i] == ' ')
                        {
                            break;
                        }
                        else
                        {
                            firstVariable += str[i];
                        }
                    }
                    break;
                }
            }
            for (; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    operation = str[i];
                    for (; i < str.Length; i++)
                    {
                        if (str[i] == ' ')
                        {
                            break;
                        }
                    }
                    break;
                }
            }
            for (; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    for (; i < str.Length; i++)
                    {
                        if (str[i] == ' ')
                        {
                            break;
                        }
                        else
                        {
                            secondVariable += str[i];
                        }
                    }
                    break;
                }
            }

            if (operation == '+')
            {
                result = Convert.ToInt32(firstVariable) + Convert.ToInt32(secondVariable);
            }
            else if (operation == '-')
            {
                result = Convert.ToInt32(firstVariable) - Convert.ToInt32(secondVariable);
            }


            Console.WriteLine(result);
        }

        static void SixthTask()
        {
            string str = ". ";
            string result = "";
            Console.WriteLine("Enter str :");
            str += Console.ReadLine();

            int i = 0;
            for (; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    for (; i < str.Length; i++)
                    {
                        if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z') ||
                            (str[i] >= 'А' && str[i] <= 'Я') || (str[i] >= 'а' && str[i] <= 'я'))
                        {
                            if ((str[i] >= 'а' && str[i] <= 'я') || str[i] >= 'a' && str[i] <= 'z')
                            {
                                result += Convert.ToChar(Convert.ToInt32(str[i]) - 32);
                                break;
                            }
                        }
                        else
                        {
                            result += str[i];
                        }
                    }
                }
                else
                {
                    result += str[i];
                }
            }

            result = result.Remove(0, 2);

            Console.WriteLine(result);
        }
        static void SeventhTask()
        {
            string str;
            string unacceptableWords = "die to";
            string temp;

            Console.WriteLine("Enter string : ");
            str = Console.ReadLine();
            
            temp = str.ToLower();

            for (int i = 0; i < temp.Length; i++)
            {
                if ((temp[i] >= 'a' && temp[i] <= 'z') || (temp[i] >= 'а' && temp[i] <= 'я'))
                {
                    string word = "";
                    for (int j = i; j < temp.Length; j++)
                    {
                        if (!(temp[j] >= 'a' && temp[j] <= 'z') && !(temp[j] >= 'а' && temp[j] <= 'я'))
                        {
                            if (unacceptableWords.Contains(word))
                            {
                                str = str.Remove(i, j - i);
                                word = new string('*', j-i);
                                str = str.Insert(i, word);
                            }
                            i = j;
                            break;
                        }
                        word += temp[j];
                    }
                }
            }

            Console.WriteLine(str);
        }
    }
}
