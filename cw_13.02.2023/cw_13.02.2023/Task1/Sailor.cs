using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Sailor : Human
    {
        public uint Payment { get; set; }
        public string Boat { get; set; }

        public Sailor(string name, int age, uint payment, string boat) : base(name, age)
        {
            Payment = payment;
            Boat = boat;
        }

        public override string ToString()
        {
            return "|Sailor|\n" + base.ToString() + $"\tPayment: {Payment}\t Firm: {Boat}";
        }
    }
}
