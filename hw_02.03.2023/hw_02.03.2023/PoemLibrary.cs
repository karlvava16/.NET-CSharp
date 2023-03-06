using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class PoemLibrary
    {
        List<Poem> poems = new List<Poem>();

        public void AddPoem()
        {
            Console.Clear();
            poems.Add(new Poem());
            Console.Write("Enter poem name: ");
            poems[poems.Count - 1].Name = Console.ReadLine();
            Console.Write("Enter author: ");
            poems[poems.Count - 1].Author = Console.ReadLine();
            Console.Write("Enter creation date (day.month.years): ");
            poems[poems.Count - 1].DateCreation = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",
                                System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Enter verse theme: ");
            poems[poems.Count - 1].VerseTheme = Console.ReadLine();
            Console.WriteLine("Enter verse text: ");
            poems[poems.Count - 1].VerseText = Console.ReadLine();
            Console.WriteLine("\n[ADDED NEW POEM]");
            Console.ReadKey();
        }

        public void RemovePoem()
        {
            Console.Clear();
            Console.Write("Enter name/author: ");
            string input = Console.ReadLine();

            List<int> indexs = new List<int>();
            int enter = 0;

            for (int i = 0; i < poems.Count; i++)
            {
                if (string.Equals(input, poems[i].Name, StringComparison.OrdinalIgnoreCase) || string.Equals(input, poems[i].Author, StringComparison.OrdinalIgnoreCase))
                {
                    indexs.Add(i);
                    Console.WriteLine($"{indexs.Count})");
                    Console.WriteLine(poems[i]);
                }
            }

            if (indexs.Count != 0)
            {
                while (true)
                {
                    Console.Write("Enter poem number to delete : ");
                    enter = Convert.ToInt32(Console.ReadLine());
                    if (enter > 0 && enter <= indexs.Count)
                    {
                        Console.WriteLine("|Delete poem|");
                        Console.WriteLine(poems[indexs[enter - 1]]);
                        poems.RemoveAt(indexs[enter - 1]);
                        break;
                    }
                    else if (enter == 0)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect index");
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no such poem");
            }
            Console.ReadKey();
        }

        public void ChangePoem()
        {
            Console.Clear();
            Console.Write("Enter name/author: ");
            string input = Console.ReadLine();

            List<int> indexs = new List<int>();
            int enter = 0;

            for (int i = 0; i < poems.Count; i++)
            {
                if (string.Equals(input, poems[i].Name, StringComparison.OrdinalIgnoreCase) || string.Equals(input, poems[i].Author, StringComparison.OrdinalIgnoreCase))
                {
                    indexs.Add(i);
                    Console.WriteLine($"{indexs.Count})");
                    Console.WriteLine(poems[i]);
                }
            }

            if (indexs.Count != 0)
            {
                while (true)
                {
                    Console.Write("Enter poem number to change : ");
                    enter = Convert.ToInt32(Console.ReadLine());
                    if (enter > 0 && enter <= indexs.Count)
                    {
                        Console.WriteLine(poems[indexs[enter - 1]]);
                        break;
                    }
                    else if (enter == 0)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect index");
                    }
                }

            }
            else
            {
                Console.WriteLine("There is no such poem");
            }
            Console.ReadKey();
        }
        public void FindPoem()
        {
            Console.Clear();
            Console.Write("Enter name/author: ");
            string input = Console.ReadLine();

            int index = 1;

            for (int i = 0; i < poems.Count; i++)
            {
                if (string.Equals(input, poems[i].Name, StringComparison.OrdinalIgnoreCase) || string.Equals(input, poems[i].Author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{index})");
                    Console.WriteLine(poems[i]);
                    index++;
                }
            }
        }

        public void SavePoems()
        {
            Console.Clear();
            Console.WriteLine("Enter file name to save: ");
            string fileName = Console.ReadLine();



        }

        public void LoadPoems()
        {
            Console.Clear();


        }

        public void Main()
        {
            char choise;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add poem");
                Console.WriteLine("2. Remove poem");
                Console.WriteLine("3. Change poem");
                Console.WriteLine("4. Find poem");
                Console.WriteLine("5. Save to file");
                Console.WriteLine("6. Load from file");

                choise = Convert.ToChar(Console.ReadLine());
                switch (choise)
                {
                    case '1':
                        AddPoem();
                        break;
                    case '2':
                        RemovePoem();
                        break;
                    case '3':
                        ChangePoem();
                        break;
                    case '4':
                        FindPoem();
                        break;
                    case '5':
                        SavePoems();
                        break;
                    case '6':
                        LoadPoems();
                        break;
                }
            }
        }
    }
}

       
}
