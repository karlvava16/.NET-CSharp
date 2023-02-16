using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Lab
{
    struct RGB
    {
        private uint r;
        private uint g;
        private uint b;

        public uint R
        {
            get { return r; }
            set
            {
                if (r <= 255)
                    r = value;
                else
                    throw new ArgumentException();
            }
        }

        public uint G
        {
            get { return g; }
            set
            {
                if (g <= 255)
                    g = value;
                else
                    throw new ArgumentException();
            }
        }

        public uint B
        {
            get { return b; }
            set
            {
                if (b <= 255)
                    b = value;
                else
                    throw new ArgumentException();
            }
        }

        public RGB(uint r, uint g, uint b) : this()
        {
            R = r;
            G = g;
            B = b;
        }

        public float[] CMYK()
        {
        }
    }
}
