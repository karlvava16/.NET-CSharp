using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     class Pilot : Human
    {
        public uint Payment { get; set; }
        public string Aircraft { get; set; }

        public Pilot (string name, int age, uint payment, string aircraft) : base(name, age)
        {
            Payment = payment;
            Aircraft = aircraft;
        }

        public override string ToString()
        {
            return "|Pilot|\n" + base.ToString() + $"\tPayment: {Payment}\t Firm: {Aircraft}";
        }
    }
}
