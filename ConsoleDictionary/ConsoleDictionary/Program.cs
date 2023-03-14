using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleDictionary
{
    internal class Program // программа консольного словаря
    {
        static BilingualDictionary dict = new BilingualDictionary("ENG-RUS");


        // список пунктов меню
        static string[] MenuParam =
        {
            "1. Show Dictionary",
            "2. Find translation",
            "3. Find word by translation",
            "4. Add word",
            "5. Add word translation",
            "6. Delete word",
            "7. Delete word translation",
            "8. Save dictionary",
            "9. Load dictionary",
            "10.Create dictionary"
        };

        delegate void MenuChoise();




        // показать весь словарь
        static void ShowDictionary()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("1. Show Dictionary\n");
            foreach (var word in dict.Dict)
            {
                Console.WriteLine(dict.Word(word.Key));
            }
            Console.ReadKey();
        }

        // показать перевод слова
        static void FindTranslation()
        {
            Console.Clear();
            string input;
            Console.WriteLine("2. Find translation\n");
            while (true)
            {
                Console.Write("Enter word: ");
                input = Console.ReadLine().ToLower();
                if (dict.ContainsWord(input))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(dict.Word(input) + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (input == "")
                    return;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[WORD DOESN'T EXIST]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }

        // найти слово по переводу
        static void FindWord()
        {
            Console.Clear();
            bool temp = true;
            string input;
            Console.WriteLine("3. Find word by translation\n");
            while (true)
            {
                Console.Write("Enter word: ");
                input = Console.ReadLine().ToLower();
                if (input != "")
                {
                    foreach (var word in dict.Dict)
                    {
                        if (word.Value.Contains(input))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine(dict.Word(word.Key) + "\n");
                            temp = false;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (temp)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[WORD DOESN'T EXIST]\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        temp = true;
                    }
                }
                else return;
            }

        }

        // добавить слово
        static void AddWord()
        {
            Console.Clear();
            Console.WriteLine("4. Add word\n");
            string word, translation;
            List<string> translations = new List<string>();
            while (true)
            {
                Console.Write("Enter new word: ");
                word = Console.ReadLine().ToLower();
                if (dict.ContainsWord(word))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[WORD ALREADY EXIST]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    continue;
                }
                else if (word == "")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("\nEnter translation:");
                    while (true)
                    {
                        translation = Console.ReadLine().ToLower();
                        if (!translations.Contains(translation) && translation != "")
                        {
                            translations.Add(translation);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("[ADDED NEW TRANSLATION]\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (translation == "")
                            break;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[TRANSLATION ALREADY EXIST]\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    if (translations.Count > 0)
                    {
                        dict.AddWord(word, translations.ToArray());
                    }
                    translations.Clear();
                }
            }
        }

        // доабвить перевод
        static void AddTranslation()
        {
            Console.Clear();
            string word, translation;

            Console.WriteLine("5. Add word translation\n");
            while (true)
            {
                Console.Write("Enter word: ");
                word = Console.ReadLine().ToLower();
                if (dict.ContainsWord(word))
                {
                    Console.WriteLine(dict.Word(word));
                    Console.WriteLine("\nEnter translation:");
                    while (true)
                    {
                        translation = Console.ReadLine().ToLower();
                        if (dict[word].Contains(translation))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[TRANSLATION ALREADY EXIST]\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (translation != "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[ADDED NEW TRANSLATIO]\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            dict.Dict[word].Add(translation);
                        }
                        else
                            break;
                    }
                    Console.Clear();
                }
                else if (word == "")
                    return;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[WORD DOESN'T EXIST]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }

        // удаление слов
        static void DeleteWord()
        {
            Console.Clear();
            Console.WriteLine("6. Delete word\n");
            string input;
            while (true)
            {
                Console.Write("Enter word: ");
                input = Console.ReadLine().ToLower();
                if (dict.ContainsWord(input))
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("[WORD REMOVED]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(dict.Word(input));
                    dict.RemoveWord(input);
                    Console.WriteLine();
                }
                else if (input == "")
                    return;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[WORD DOESN'T EXIST]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }

        static void DeleteTranslation()
        {
            Console.Clear();
            Console.WriteLine("7. Delete word translation\n");
            string word, translation;

            while (true)
            {
                Console.Write("Enter word: ");
                word = Console.ReadLine().ToLower();
                if (dict.ContainsWord(word))
                {
                    Console.WriteLine(dict.Word(word));
                    Console.WriteLine("\nEnter translation:");
                    while (true)
                    {
                        translation = Console.ReadLine().ToLower();
                        if (dict.Dict[word].Contains(translation))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("[TRANSLATION REMOVED]\n");
                            Console.ForegroundColor = ConsoleColor.Green;

                            dict.Dict[word].Remove(translation);
                        }
                        else if (translation == "")
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[TRANSLATION DOESN'T EXIST]\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    Console.WriteLine();
                }
                else if (word == "")
                    return;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[WORD DOESN'T EXIST]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }

        static void SaveDictionary()
        {
            Console.Clear();
            Console.WriteLine("8. Save dictionary\n");
            string filename;

            while (true)
            {
                Console.Write("Enter file_name.json : ");
                filename = Console.ReadLine();
                if (filename == "")
                    return;
                Regex regex = new Regex("[\\w\\s_]{1,}.json");
                if (regex.IsMatch(filename))
                {
                    BilingualDictionaryJson.Save(filename, dict);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"[SAVE TO {filename}]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[FILENAME DOESN'T MATCH]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

            }
        }

        static void LoadDictionary()
        {
            Console.Clear();
            Console.WriteLine("9. Load dictionary\n");
            string filename;

            while (true)
            {
                Console.Write("Enter file_name.json : ");
                filename = Console.ReadLine();
                if (filename == "")
                    return;
                Regex regex = new Regex("[\\w\\s_]{1,}.json");
                if (regex.IsMatch(filename))
                {
                    BilingualDictionaryJson.Load(filename, ref dict);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"[LAOD FROM {filename}]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[FILENAME DOESN'T MATCH]\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

            }
        }

        static void CreateDictionary()
        {
            ConsoleKey key;
            Console.Clear();
            Console.WriteLine("10. Create dictionary\n");
            if (dict.Dict.Count != 0)
            {
                Console.WriteLine("Exist other dicrionary. Do agree that you will lose it? [ENTER/ESC]");
                while (true)
                {
                    key = Console.ReadKey().Key;
                    if (key == ConsoleKey.Escape)
                        return;
                    else if (key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            else
            {
                string type;
                Regex regex = new Regex("\\w{2,3}-\\w{2,3}");
                while (true)
                {
                    Console.Write("Enter dictionary type (EXAMPLE: ENG-RUS): ");
                    type = Console.ReadLine();
                    if (regex.IsMatch(type))
                    {
                        dict = new BilingualDictionary(type);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("[CREATED NEW DICTIONARY]\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.ReadKey();
                        return;
                    }
                    else if (type == "")
                        return;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[TYPE DOESN'T MATCH]\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int selectedItem = 0;
            ConsoleKey key;


            MenuChoise[] delegates = new MenuChoise[10];
            delegates[0] = ShowDictionary;
            delegates[1] = FindTranslation;
            delegates[2] = FindWord;
            delegates[3] = AddWord;
            delegates[4] = AddTranslation;
            delegates[5] = DeleteWord;
            delegates[6] = DeleteTranslation;
            delegates[7] = SaveDictionary;
            delegates[8] = LoadDictionary;
            delegates[9] = CreateDictionary;


            Console.CursorVisible = false;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dict.DictType);
                Console.ResetColor();
                for (int i = 0; i < MenuParam.Length; i++)
                {
                    if (i == selectedItem)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(MenuParam[i]);
                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        delegates[selectedItem].Invoke();
                        Console.CursorVisible = false;
                        break;
                    case ConsoleKey.UpArrow:
                        selectedItem = selectedItem == 0 ? MenuParam.Length - 1 : selectedItem - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        selectedItem = selectedItem == MenuParam.Length - 1 ? 0 : selectedItem + 1;
                        break;
                }

            } while (key != ConsoleKey.Escape);
        }
    }
}
