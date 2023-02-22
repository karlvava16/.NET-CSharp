using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{

    delegate void MyDelegate(Items a);

    class Backpack
    {
        public event MyDelegate addItem;


        string Color { get; set; }
        string Firm { get; set; }
        string Fabric { get; set; }
        double Mass { get; set; }
        public double V { get; set; }

        List<Items> Objects = new List<Items>(16);

        public Backpack() { }
        public Backpack(string color, string firm, string fabric, double mass, double v)
        {
            Color = color;
            Firm = firm;
            Fabric = fabric;
            Mass = mass;
            V = v;

            addItem = new MyDelegate((Items a) =>
            {
                if (V - a.v >= 0)
                {
                    Objects.Add(a);
                    V += a.v;
                }
                else
                {
                    throw new Exception("Error");
                }
            });


        }

        public void AddItem(Items A)
        {
            addItem?.Invoke(A);
        }


    }

    class Items
    {

        string name;
        public double v { get; set; }

        public Items(string name, double v)
        {
            this.name = name;
            this.v = v;
        }
    }
    
}
