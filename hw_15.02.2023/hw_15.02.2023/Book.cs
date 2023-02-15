using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Book : IComparable, ICloneable
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


        public static bool operator ==(Book a, Book b)
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

        public static bool operator !=(Book a, Book b)
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

        public int CompareTo(object obj)
        {
            return Name.CompareTo((obj as Book).Name);
            throw new NotImplementedException();
        }

        public object Clone()
        {
            return new Book(Name, Author, Description, PageAmount);
        }

        public class SortByName : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).Name.CompareTo((obj2 as Book).Name);
                throw new NotImplementedException();
            }
        }

        public class SortByAuthor : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).Author.CompareTo((obj2 as Book).Author);
                throw new NotImplementedException();
            }
        }

        public class SortByPage : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).PageAmount.CompareTo((obj2 as Book).PageAmount);
                throw new NotImplementedException();
            }
        }

        public class SortByDescription : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                    return (obj1 as Book).Description.CompareTo((obj2 as Book).Description);
                throw new NotImplementedException();
            }
        }
    }
}
