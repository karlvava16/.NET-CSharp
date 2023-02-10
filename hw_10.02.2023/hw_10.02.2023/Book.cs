using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Book
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        
        public uint PageAmount { get; set; }


        public Book() { }

        public Book(string name, string author, string description, uint pageAmount)
        {
            Name = name;
            Description = description;
            Author = author;
            PageAmount = pageAmount;
        }


        public static bool operator==(Book a, Book b)
        {
            if (a.Name != b.Name)
                return false;
            if (a.Author != b.Author)
                return false;
            if (a.PageAmount != b.PageAmount)
                return false;
            if (a.Description != b.Description)
                return false;
            return true;
        }

        public static bool operator!=(Book a, Book b)
        {
            return !(a == b);
        }

        public static bool operator >(Book a, Book b)
        {
            return a.PageAmount > b.PageAmount;
        }

        public static bool operator <(Book a, Book b)
        {
            return a.PageAmount < b.PageAmount;
        }

        public static bool operator >=(Book a, Book b)
        {
            return a.PageAmount >= b.PageAmount;
        }

        public static bool operator <=(Book a, Book b)
        {
            return a.PageAmount <= b.PageAmount;
        }

        public override string ToString()
        {
            return $"Book name : {Name}\nAuthor : {Author}\nPage Amount : {PageAmount}\nDescription :\n{Description}\n";
        }
    }
}
