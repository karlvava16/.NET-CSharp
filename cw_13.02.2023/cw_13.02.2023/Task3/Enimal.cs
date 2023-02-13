using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Enimal
    {
        public string Name { get; set; }
        public uint Weight { get; set; }

        public Enimal(string name, uint weight) 
        { 
            Name = name;
            Weight = weight;
        }

        public override string ToString() 
        {
            return $"Name: {Name}\t Weight: {Weight}";
        }
    }
}
