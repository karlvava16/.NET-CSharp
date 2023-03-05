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
            poems[poems.Count - 1].VerseTheme= Console.ReadLine();
            Console.WriteLine("Enter verse text: ");
            poems[poems.Count - 1].VerseText = Console.ReadLine();
            Console.WriteLine("\n[ADDED NEW POEM]");
            Console.ReadKey();
        }

        public void RemovePoem()
        {
            Console.Clear();

        }

        public void ChangePoem()
        {
            Console.Clear();

        }

        public void FindPoem()
        {
            Console.Clear();

        }

        public void SavePoems()
        {
            Console.Clear();

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
