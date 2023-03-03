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

        }

        public void RemovePoem()
        {
            
        }

        public void ChangePoem()
        {

        }

        public void FindPoem()
        {

        }

        public void SavePoems()
        {
            
        }

        public void LoadPoems()
        {

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
