using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace nsATM
{
    class ATM
    {
        string mac;
        string firm;
        IMoney money;
        IPrint print;

        public void SetCurrency(IMoney money)
        {
            this.money = money;
        }
        public void SetPrint(IPrint print)
        {
            this.print = print;
        }



        public string GetCheck()
        {
            return "Method to get check : " + print?.Write() + "\n" +
                "Entered amount of money : " + money?.ToString();

        }
    }
}
