using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace nsMoney
{
    abstract class Money : IMoney
    {
        public uint Amount { get; set; }

        public char cSymbol { get; }

        public Money(uint amount, char symbol)
        {
            Amount = amount;
            cSymbol = symbol;
        }
    }

    class UAH : Money
    {
        public UAH(uint amount = 0) : base(amount, '₴') { }
        public override string ToString()
        {
            return Amount + " " + cSymbol;
        }
    }

    class USD : Money
    {
        public USD(uint amount = 0) : base(amount, '$') { }
        public override string ToString()
        {
            return Amount + " " + cSymbol;
        }
    }

    class EUR : Money
    {
        public EUR(uint amount = 0) : base(amount, '€') { }
        public override string ToString()
        {
            return Amount + " " + cSymbol;
        }
    }
}
