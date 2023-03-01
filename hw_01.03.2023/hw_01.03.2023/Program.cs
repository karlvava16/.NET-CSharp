using System;

namespace Homework
{
    enum Types
    {
        Producted,
        House,
        Clothes,
        Shoes
    };
    class Shop : IDisposable
    {

        public string Name { get; set; }
        public string Address { get; set; }

        public int Type { get; set; }

        public Shop()
        {
            Name = null;
            Address = null;
            Type = -1;

        }
        public Shop(string Name, string Address, int type)
        {
            this.Name = Name;
            this.Address = Address;
            Type = type;
        }
        ~Shop()
        {
            Console.WriteLine("Object destoy Shop");
        }
        private bool disposed = false;
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
            Console.WriteLine("Object disposed Shop");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            for (int i = 0; i < 3; i++)
            {
                Play a = new Play("Name", "Surname", "Author_name", new DateTime(2023,03,01));
            }
            for (int i = 0; i < 2; i++)
            {
                using (Play z = new Play())
                {

                };
            }
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            //task2
            for (int i = 0; i < 3; i++)
            {
                using (Shop s = new Shop())
                {

                };

            }
        }
    }
}