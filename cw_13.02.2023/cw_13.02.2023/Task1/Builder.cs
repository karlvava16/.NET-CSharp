using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Builder : Human
    {
        public uint Payment { get; set; }
        public string Firm { get; set; }

        public Builder(string name, int age, uint payment, string firm) : base(name, age)
        {
            Payment = payment;
            Firm = firm;
        }

        public override string ToString()
        {
            return "|Builder|\n" + base.ToString() + $"\tPayment: {Payment}\t Firm: {Firm}";
        }
    }
}
