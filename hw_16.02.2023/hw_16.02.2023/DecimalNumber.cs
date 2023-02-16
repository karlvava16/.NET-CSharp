using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    struct DecimalNumber
    {
        public int Value { get; set; }

        public DecimalNumber(int value)
        {
            Value = value;
        }

        public string Octal()
        {
            return Convert.ToString(Value, 8);

        }

        public string Hex()
        {
            return Convert.ToString(Value, 16);
        }

        public string Binary()
        {
           return Convert.ToString(Value, 2);
        }

    }
}
