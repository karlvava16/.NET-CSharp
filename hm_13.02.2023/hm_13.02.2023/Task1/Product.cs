using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{


    class Money
    {
        public string СurrencyM { get; set; }

        public double Value { get; set; }


        public Money(double value, string currency = "$")
        {
            Value = value;
            СurrencyM = currency;
        }

        public double Low(double v)
        { Value -= v; return Value; }

        public double Up(double v)
        { Value += v; return Value; }

        public override string ToString()
        {
            return Value + СurrencyM;
        }
    }


        class Product : Money
        {
        public string Name { get; set; }
        public string Description { get; set; }
        public Product(string name, string description, double moneyMoney) : base(moneyMoney)
        {
            Name = name;
            Description = description;
        }

        public Product(string name, string description, double moneyMoney, string currency) : base(moneyMoney, currency)
        {
            Name = name;
            Description = description;
        }

        public override string ToString() 
        {
            return $"Product Name: {Name}\nMoney: {base.ToString()}\nDescription: {Description}\n";
        }
    }

}