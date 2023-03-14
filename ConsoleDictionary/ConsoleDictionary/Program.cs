using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BilingualDictionary test1 = new BilingualDictionary("ENG");
            BilingualDictionary test2 = new BilingualDictionary("ENG");
            test1.AddWord("dog", "собака", "пес", "псина");
            test1.AddWord("cat", "кошка", "котик");
            foreach (var word in test1.Dict) 
            {
                Console.WriteLine(word.Key);
                foreach (var tr in word.Value)
                {
                    Console.Write(tr + "\t");
                }
                Console.WriteLine();
            }
            BilingualDictionaryJson.Save("test.json", test1);
            BilingualDictionaryJson.Load("test.json", ref test2);
            Console.WriteLine();

            foreach (var word in test2.Dict)
            {
                Console.WriteLine(word.Key);
                foreach (var tr in word.Value)
                {
                    Console.Write(tr + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
