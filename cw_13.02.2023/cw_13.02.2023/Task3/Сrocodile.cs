using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Сrocodile : Enimal
    {
        public uint JawStrength { get; set; }
        public Сrocodile(string name, uint weight, uint jawStrength) : base(name, weight)
        {
            JawStrength = jawStrength;
        }

        public override string ToString()
        {
            return $"|Сrocodile|\n" + base.ToString() + $"Jaw Strength: {JawStrength}";
        }
    }
}
