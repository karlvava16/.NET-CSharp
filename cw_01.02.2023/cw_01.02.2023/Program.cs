using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cw_01._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitWithRand();
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();
            FifthTask();
            SixthTask();
            SeventhTask();
            EighthTask();
            NinthTask();
        }

        static void InitWithRand()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 20);
            foreach (int item in arr)
            {
                Console.Write("{0, 4}", item);
            }
            Console.WriteLine();
        }

        static void FirstTask()
        {
            int negative = 0, positive = 0, uniqueAmount = 0;
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-10, 10);

            foreach (int item in arr)
            {
                Console.Write("{0,4}", item);
            }
            Console.WriteLine();

            foreach (int item in arr)
            {
                if(item < 0)
                {
                    negative++;
                }
                else
                {
                    positive++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                uniqueAmount++;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        uniqueAmount--;
                        break;
                    }
                }
            }

            Console.WriteLine($"Negative : {negative}");
            Console.WriteLine($"Positive : {positive}");
            Console.WriteLine($"Unigue : {uniqueAmount}");
        }

        static void SecondTask()
        {
            int[] arr = new int[10];
            int value;
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 10);
            }
            foreach (int item in arr)
            {
                Console.Write("{0,4}", item);
            }
            Console.WriteLine();
            Console.Write("Enter value : ");
            value = Convert.ToInt32(Console.ReadLine());
            foreach (int item in arr)
            {
                if(item < value)
                    count++;
            }
            Console.WriteLine($"{count} elemets lower then {value}");
        }

        static void ThirdTask()
        {
            int[] arr = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5};
            int[] input = new int[3];
            int count = 0;

            foreach (int item in arr)
            {
                Console.Write("{0,4}", item);
            }
            Console.WriteLine() ;

            Console.Write("Enter first number : ");
            input[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            input[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            input[2] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length - input.Length + 1; i++)
            {
                if (arr[i] == input[0] && arr[i + 1] == input[1] && arr[i + 2] == input[2])
                {
                    count++;
                }
            }

            Console.WriteLine("Amount : {0}", count);
        }

        static void FourthTask()
        {
            Random rand = new Random();
            int[] arr = new int[rand.Next(5, 10)];
            int[] arr2 = new int[rand.Next(5, 10)];
            int[] arr3;
            string temp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 10);
            }


            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(0, 10);
            }

            foreach (int item in arr)
            {
                Console.Write("{0,4}", item);
            }
            Console.WriteLine();
            foreach (int item in arr2)
            {
                Console.Write("{0,4}", item);
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr[i] == arr2[j] && temp.IndexOf(arr[i].ToString()) == -1)
                    {
                        temp += arr[i].ToString();
                    }
                }
            }

            arr3 = new int[temp.Length];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = Convert.ToInt32(temp[i].ToString());
            }

            foreach (int item in arr3)
            {
                Console.Write("{0,4}", item);
            }
            Console.WriteLine();
        }

        static void FifthTask()
        {
            int[,] arr = new int[10, 10];
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
               for (int j = 0; j < arr.GetLength(1); j++) 
                {
                    arr[i,j] = rand.Next(0, 10);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Max : {0}", (from int v in arr select v).Max());
            Console.WriteLine("Min : {0}", (from int v in arr select v).Min());
        }

        static void SixthTask()
        {
            string str;
            int count = 0;
            Console.WriteLine("Enter sentence : ");
            str = Console.ReadLine().ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'а' && str[i] <= 'я')
                {
                    count++;
                    for (; i < str.Length; i++)
                    {
                        if (!(str[i] >= 'a' && str[i] <= 'z') && !(str[i] >= 'а' && str[i] <= 'я'))
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Words : {0}", count);
        }

        static void SeventhTask()
        {
            string str;
            string str2 = "";
            Console.WriteLine("Enter sentence : ");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'а' && str[i] <= 'я')
                {
                    int j = i;
                    for (; i < str.Length; i++)
                    {
                        if (!(str[i] >= 'a' && str[i] <= 'z') && !(str[i] >= 'а' && str[i] <= 'я'))
                        {
                            break;
                        }
                    }
                    for (int k = i - 1; k >= j; k--)
                    {
                        str2 += str[k];
                    }
                }
                str2 += str[i];
            }
            Console.WriteLine();
            Console.WriteLine(str2);
        }

        static void EighthTask()
        {
            string str;
            int count = 0;
            char[] vowels = { 'а', 'я', 'у', 'ю', 'о', 'е', 'ё', 'э', 'и', 'ы', 'a', 'e', 'i', 'o', 'u', 'y' };
            
            Console.WriteLine("Enter sentence : ");
            str = Console.ReadLine().ToLower();
            
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Words : {0}", count);
        }

        static void NinthTask()
        {
            string str;
            string subStr;
            int count = 0;
            Console.WriteLine("Enter sentence : ");
            str = Console.ReadLine().ToLower();

            Console.Write("Enter sub str : ");
            subStr = Console.ReadLine().ToLower();

            for (int i = 0; i < str.Length - subStr.Length + 1; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'а' && str[i] <= 'я')
                {
                    for (int j = 0; j < subStr.Length && i < str.Length - subStr.Length + 1; j++, i++)
                    {
                        if (str[i] != subStr[j])
                        {
                            for (; i < str.Length - subStr.Length + 1; i++)
                            {
                                if (str[i] == ' ')
                                {
                                    break;
                                }
                            }
                            count--;
                            break;
                        }
                    }
                    count++;
                    if (i < str.Length - subStr.Length + 1 && str[i] != ' ')
                        count--;
                }

            }
            Console.WriteLine();
            Console.WriteLine("SubStr amount : {0}", count);
        }
    }
}
