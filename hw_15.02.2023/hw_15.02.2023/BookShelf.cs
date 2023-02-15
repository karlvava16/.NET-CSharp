using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Homework
{
    public class Library
    {
        private Book[] books;

        public Book[] Books { get { return books; } set { books = value; } }

        public Library() { }
        public Library(params Book[] books)
        {
            Books  = new Book[books.Length];
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i] = books[i];
            }
        }

        public Book this[int index]
        {
            get
            {
                if (!(index >= 0 && index < Books.Length))
                    throw new ArgumentOutOfRangeException(index.ToString());
                return Books[index];
            }
            set
            {
                if (!(index >= 0 && index < Books.Length))
                    throw new ArgumentOutOfRangeException("index");
                if(value.Name == null)
                    throw new Exception("Book without name");
                if (value.Author == null)
                    throw new Exception("Book without author");
                if (value.Description == null)
                    throw new Exception("Book without description");
                Books[index] = value;
            }
        }

        public bool Push(Book a, int index)
        {
            if (!(index >= 0 && index <= Books.Length))
                throw new ArgumentOutOfRangeException("index");
            if (a.Name == null)
                throw new Exception("Book without name");
            if (a.Author == null)
                throw new Exception("Book without author");
            if (a.Description == null)
                throw new Exception("Book without description");

            Book[] temp = new Book[books.Length + 1];
            int i = 0;
            for (; i < index; i++)
            {
                temp[i] = Books[i];
            }
            temp[index] = a;
            i++;
            for (; i < temp.Length; i++)
            {
                temp[i] = Books[i - 1];
            }
            Books = temp;
            return true;
        }

        public static Library operator+ (Library bs, Book b)
        {
            Library temp = bs;
            bs.Push(b);
            return temp;
        }

        public static Library operator +(Book b,Library bs)
        {
            Library temp = bs;
            bs.Push(b);
            return temp;
        }

        public bool Push(Book a)
        {
            if (a.Name == null)
                throw new Exception("Book without name");
            if (a.Author == null)
                throw new Exception("Book without author");
            if (a.Description == null)
                throw new Exception("Book without description");

            Book[] temp = new Book[books.Length + 1];
            for (int i = 0; i < books.Length; i++)
            {
                temp[i] = Books[i];
            }
            temp[temp.Length - 1] = a;
            Books = temp;
            return true;
        }


        public Book Pull()
        {
            Book b = Books[Books.Length - 1];
            Book[] temp = new Book[books.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = Books[i];
            }
            Books = temp;
            return b;
        }

        public Book Pull(int index)
        {
            if(!(index >= 0 && index < Books.Length))
                throw new ArgumentOutOfRangeException(index.ToString());
            Book b = Books[index];
            Book[] temp = new Book[books.Length - 1];
            int i = 0;
            for (; i < index; i++)
            {
                temp[i] = Books[i];
            }
            for (; i < Books.Length - 1; i++)
            {
                temp[i] = Books[i + 1];
            }
            Books = temp;
            return b;
        }


        public int GetLength()
        {
            return Books.Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < books.Length; i++)
            {
                sb.Append($"|Book No.{i + 1}|\n" + books[i] + '\n');
            }
            return sb.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Books.Length; i++)
                yield return Books[i];
            // При обращении к оператору yield return будет сохраняться текущее местоположение.
            // И когда foreach перейдет к следующей итерации для получения нового объекта, 
            // итератор начнет выполнение с этого местоположения.
        }
    }
}
