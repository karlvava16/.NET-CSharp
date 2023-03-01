using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Play : IDisposable
    {
        public string PlayName { get; set; }
        public string Gendre { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }

        private bool disposed = false;

        public Play () { }

        public Play(string playName, string gendre, string author, DateTime createDate)
        {
            PlayName = playName;
            Gendre = gendre;
            Author = author;
            CreateDate = createDate;
        }


        protected virtual void Clean(bool disposing)
        {

            if (!this.disposed)
            {
                if (disposing)
                {

                }

            }
            disposed = true;
        }

        public void Dispose()
        {
            Clean(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("Object disposed Play");
        }
        ~Play()
        {
            Clean(false);
            Console.WriteLine("Object destoy Play");
        }

        public override string ToString()
        {
            return $"Play : \"{PlayName}\"\nGendre : {Gendre}\nAuthor : {Author}\n Date : {CreateDate.ToString("dd.MM.yyyy")}\n";
        }
    }
}
