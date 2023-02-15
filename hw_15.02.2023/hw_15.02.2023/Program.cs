using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library bs = new Library(new Book("book1", "me3", "cool", 200), new Book("book2", "me1", "not so cool", 5000));
            bs.Push(new Book("book3", "m1", "better ^)", 300), 0);


            foreach (Book book in bs) 
            {
            Console.WriteLine(book);
            Console.WriteLine("-------------------------------");
            }

            Array.Sort(bs.Books, new Book.SortByPage());


            Console.WriteLine("+++++++++++++++++++++++++++++++");


            foreach (Book book in bs)
            {
                Console.WriteLine(book);
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
