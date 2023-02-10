using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Homework;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookShelf bs = new BookShelf(new Book("book1", "me", "cool", 200), new Book("book2", "me", "not so cool", 5000));
            Console.WriteLine(bs);
            Console.WriteLine("------------------------------------");
            bs.Push(new Book("book3", "me", "better ^)", 300), 0);
            Console.WriteLine(bs);
            Console.WriteLine("------------------------------------");
            bs.Pull(1);
            Console.WriteLine(bs);
        }
    }
}
