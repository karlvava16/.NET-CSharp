using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Tiger : Enimal
    {
        public uint Speed { get; set; }
        public Tiger(string name, uint weight, uint speed) : base(name,weight)
        {
            Speed = speed;
        }

        public override string ToString()
        {
            return $"|TIGER|\n" + base.ToString() + $"Speed: {Speed}";
        }
    }
}
