using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bank;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankCard card = new BankCard("MonoBank", "123A 5678 9111 1121", "212", "10/25");
           // card.CardCVV = "BB1";
            Console.WriteLine(card);
        }
    }
}
