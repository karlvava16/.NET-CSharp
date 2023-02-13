using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Kangaroo : Enimal
    {
        public uint JumpHeight { get; set; }
        public Kangaroo(string name, uint weight, uint jumpHeight) : base(name, weight)
        {
            JumpHeight = jumpHeight;
        }

        public override string ToString()
        {
            return $"|Kangaroo|\n" + base.ToString() + $"Jump Height: {JumpHeight}";
        }
    }
}
