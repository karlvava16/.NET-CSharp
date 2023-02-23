using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nsATM;
using nsMoney;
using nsPrint;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            int chooseCurrency;
            int amount;
            int choosePrint;
            Console.WriteLine("Choose currency (UAH - 1, USD - 2, EUR - 3) : ");
            chooseCurrency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount : ");
            amount = Convert.ToInt32(Console.ReadLine());
            
            switch (chooseCurrency) 
            {
                case 1: atm.SetCurrency(new UAH((uint)amount)); break;
                case 2: atm.SetCurrency(new USD((uint)amount)); break;
                case 3: atm.SetCurrency(new EUR((uint)amount)); break;
                default: throw new Exception("Unexpected currency");
            }

            Console.WriteLine("Enter how to print (Output on screen - 1, Send SMS - 2, Print on paper - 3) : ");
            choosePrint= Convert.ToInt32(Console.ReadLine());

            switch (choosePrint)
            {
                case 1: atm.SetPrint(new Show()); break;
                case 2: atm.SetPrint(new SMS()); break;
                case 3: atm.SetPrint(new PrintCheck()); break;
            }

            Console.WriteLine(atm.GetCheck());
        }
    }
}
