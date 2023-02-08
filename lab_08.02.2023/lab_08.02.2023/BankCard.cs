using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankCard
    {
        private string bankName;
        private string cardNumber;
        private string cardCVV;
        DateTime cardDedline;

        public string BankName { get { return bankName; } set { bankName = value; } }

        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                string temp = value.ToString().Replace(" ", "");
                try
                {
                    if (temp.Length != 16)
                    {
                        throw new Exception("Unaccessable card number length");
                    }

                    foreach (var el in temp)
                    {
                        if (!(el >= '0' && el <= '9'))
                        {
                            throw new Exception("Unaccessable symbol in card number");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                cardNumber = temp;
            }
        }

        public string CardCVV 
        { 
            get { return cardCVV; }
            set 
            {
                string temp = value.ToString().Replace(" ", "");
                if (temp.Length != 3)
                {
                    throw new Exception("Unaccessable CVV length");
                }

                foreach (var el in temp)
                {
                    if (!(el >= '0' && el <= '9'))
                    {
                        throw new Exception("Unaccessable symbol in CVV");
                    }
                }

                cardCVV = temp;
            }
        }

        public DateTime CardDedline { get { return cardDedline; } set { cardDedline = value; } }


        public BankCard() { }

        public BankCard(string bankName)
        {
            BankName = bankName;
        }

        public BankCard(string bankName, string card_number) : this(bankName)
        {
            CardNumber = card_number;
        }

        public BankCard(string bankName, string cardNumber, string cardCVV) : this(bankName, cardNumber)
        {
            CardCVV = cardCVV;
        }

        public BankCard(string bankName, string cardNumber, string cardCVV, string cardDedline) : this(bankName, cardNumber, cardCVV)
        { 
           CardDedline = DateTime.ParseExact(cardDedline, "MM/yy", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"Bank : {BankName}\nCard number : {cardNumber}\nCVV : {cardCVV}\nCard dedline : {CardDedline.ToString("MM/yy")}\n";
        }
    }
}
