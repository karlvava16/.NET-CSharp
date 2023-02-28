using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class EnglishRussianDict
    {
        SortedDictionary<string, string> englishRussianDict = new SortedDictionary<string, string>();

        void AddWord()
        {
            Console.Clear();

            string eng;
            string rus;

            Console.Write("Enter eng: ");
            eng = Console.ReadLine();
            if (englishRussianDict.ContainsKey(eng))
            {
                Console.WriteLine("Already exist");
                return;
            }
            Console.Write("Enter rus: ");
            rus = Console.ReadLine();
            englishRussianDict.Add(eng, rus);
            Console.ReadKey();
        }

        void DeleteWord()
        {
            Console.Clear();

            bool choise;
            string word;
            Console.Write("Enter eng(true) or rus(false): ");
            choise = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter word to remove: ");
            word = Console.ReadLine().ToLower();

            if (choise) //enghish
            {
                if (englishRussianDict.ContainsKey(word))
                    englishRussianDict.Remove(word);
                else
                    Console.WriteLine(word + "doesn't exist");
            }
            else
            {
                if (englishRussianDict.ContainsValue(word))
                {
                    englishRussianDict.Remove(word);
                }
                else
                    Console.WriteLine(word + "doesn't exist");
            }
            Console.ReadKey();

        }

        void FindE()
        {
            string word;
            Console.Write("Enter english word: ");
            word = Console.ReadLine().ToLower();
            if (englishRussianDict.ContainsKey(word))
                Console.WriteLine(englishRussianDict[word]);
            else
                Console.WriteLine(word + "doesn't exist");
            Console.ReadKey();
        }

        void FindR()
        {
            Console.Clear();

            string word;
            Console.Write("Enter russian word: ");
            word = Console.ReadLine().ToLower();
            if (englishRussianDict.ContainsValue(word))
            {
                foreach (var item in englishRussianDict)
                {
                    if (item.Value == word)
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
            }
            else
                Console.WriteLine(word + "doesn't exist");
            Console.ReadKey();

        }

        void ShowDict()
        {
            Console.Clear();
            foreach (var item in englishRussianDict)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void Start()
        {
            char choise;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Add word");
                Console.WriteLine("2.Delete word");
                Console.WriteLine("3.Enter english get russian");
                Console.WriteLine("4.Enter russian get english");
                Console.WriteLine("5.Show dictionary");
                Console.WriteLine("6.Exit");
                choise = Convert.ToChar(Console.ReadLine());
                switch (choise)
                {
                    case '1':
                        AddWord();
                        break;
                    case '2':
                        DeleteWord();
                        break;
                    case '3':
                        FindE();

                        break;
                    case '4':
                        FindR();

                        break;
                    case '5':
                        ShowDict();
                        break;
                    case '6':
                        Console.Clear();
                        return;
                }

            }
        }
    }
}
