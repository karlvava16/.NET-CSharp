using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hw_03._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            Task15();
        }

        static void Task8()
        {
            StringBuilder strBld = new StringBuilder();
            int index;

            Console.WriteLine("Enter string : ");
            strBld.Append(Console.ReadLine());

            Console.Write("Enter character index to remove : ");
            index = Convert.ToInt32(Console.ReadLine());

            strBld.Remove(index, 1);
            Console.WriteLine(strBld);
        }

        static void Task9()
        {
            StringBuilder strBld;
            char character;

            Console.WriteLine("Enter string : ");
            strBld = new StringBuilder(Console.ReadLine());

            Console.Write("Enter character to remove : ");
            character = Convert.ToChar(Console.ReadLine());

            strBld.Replace(character.ToString(), "");

            Console.WriteLine(strBld);
        }

        static void Task10()
        {
            StringBuilder strBld;
            char character;
            int index;

            Console.WriteLine("Enter string : ");
            strBld = new StringBuilder(Console.ReadLine());

            Console.Write("Enter character to insert : ");
            character = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter character index to insert : ");
            index = Convert.ToInt32(Console.ReadLine());

            strBld.Insert(index, character.ToString());

            Console.WriteLine(strBld);
        }

        static void Task11()
        {
            string str;

            Console.WriteLine("Enter string : ");
            str = Console.ReadLine();

            char[] array = str.ToCharArray();

            Array.Reverse(array);

            Console.WriteLine(array);

            if (str == new string(array))
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not a palindrom");
            }
        }

        static void Task12()
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

        static void Task13()
        {
            StringBuilder str;
            string toReplace;
            string toInsert;
            Console.WriteLine("Enter str : ");
            str = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Enter str to replace : ");
            toReplace = Console.ReadLine();

            Console.WriteLine("Enter str to insert : ");
            toInsert = Console.ReadLine();

            str.Replace(toReplace, toInsert);

            Console.WriteLine(str);

        }

        static void Task14()
        {
            string str;
            Console.WriteLine("Enter str : ");
            str = Console.ReadLine();

            string[] strings = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strings.Length - 1; i += 2)
            {
                (strings[i], strings[i + 1]) = (strings[i + 1], strings[i]);
            }
            str = string.Join(" ", strings);

            Console.WriteLine(str);
        }

        static void Task15()
        {
            string str;
            Console.WriteLine("Enter str : ");
            str = Console.ReadLine().ToLower();

            int count = 0;

            string vowels = "аяуюоеёэиыaeiouy";



            string[] strings = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strings.Length; i++)
            {
                if (vowels.Contains(strings[i][strings[i].Length - 1]))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
