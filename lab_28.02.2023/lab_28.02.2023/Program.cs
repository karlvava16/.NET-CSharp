using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        static void Task1()
        {
            EnglishRussianDict dict= new EnglishRussianDict();
            dict.Start();
        }

        static void Task2()
        {
            string[] words;
            Dictionary<string, int>  dict = new Dictionary<string, int>();
            Console.WriteLine("Enter text: ");
            words = Console.ReadLine().ToLower().Split(' ');
            foreach (string word in words) 
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                    continue;
                }
                dict.Add(word, 1);
            }
            foreach (var el in dict) 
            {
                Console.WriteLine(el.Key + "\t" + el.Value);
            }

        }

        static void Main(string[] args)
        {
       Task1();
            Task2();
        }
    }
}
