using System;


namespace Homework
{

    public class CreditCard
    {
        private string cardNumber;
        private string cardHolderName;
        private DateTime expiryDate;
        private string pin;
        private decimal creditLimit;
        private decimal balance;

        // События
        public event EventHandler<AccountChangedEventArgs> BalanceChanged;
        public event EventHandler<AccountChangedEventArgs> CreditLimitChanged;
        public event EventHandler<AccountChangedEventArgs> ExceededCreditLimit;
        public event EventHandler<AccountChangedEventArgs> PinChanged;

        public CreditCard(string cardNumber, string cardHolderName, DateTime expiryDate, string pin, decimal creditLimit, decimal balance)
        {
            this.cardNumber = cardNumber;
            this.cardHolderName = cardHolderName;
            this.expiryDate = expiryDate;
            this.pin = pin;
            this.creditLimit = creditLimit;
            this.balance = balance;
        }

        // Методы для изменения PIN-кода и кредитного лимита
        public void ChangePin(string oldPin, string newPin)
        {
            if (oldPin == pin)
            {
                pin = newPin;
                OnPinChanged(new AccountChangedEventArgs($"Pin code changed to {newPin}."));
            }
            else
            {
                throw new Exception("Invalid PIN.");
            }
        }

        public void ChangeCreditLimit(decimal newCreditLimit)
        {
            creditLimit = newCreditLimit;
            OnCreditLimitChanged(new AccountChangedEventArgs($"Credit limit changed to {newCreditLimit:C}."));
        }

        // Методы для пополнения и списания средств со счёта
        public void Deposit(decimal amount)
        {
            balance += amount;
            OnBalanceChanged(new AccountChangedEventArgs($"Deposited {amount:C}. New balance: {balance:C}."));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance + creditLimit)
            {
                balance -= amount;
                OnBalanceChanged(new AccountChangedEventArgs($"Withdrawn {amount:C}. New balance: {balance:C}."));
                if (balance < 0)
                {
                    OnExceededCreditLimit(new AccountChangedEventArgs($"Credit limit exceeded. Balance: {balance:C}."));
                }
            }
            else
            {
                throw new Exception("Insufficient funds.");
            }
        }

        // Методы для начала и окончания использования кредитных денег
        public void StartUsingCredit()
        {
            OnBalanceChanged(new AccountChangedEventArgs("Started using credit."));
        }

        public void StopUsingCredit()
        {
            OnBalanceChanged(new AccountChangedEventArgs("Stopped using credit."));
        }

        // Вспомогательные методы для вызова событий
        protected virtual void OnBalanceChanged(AccountChangedEventArgs e)
        {
            BalanceChanged?.Invoke(this, e);
        }

        protected virtual void OnCreditLimitChanged(AccountChangedEventArgs e)
        {
            CreditLimitChanged?.Invoke(this, e);
        }

        protected virtual void OnExceededCreditLimit(AccountChangedEventArgs e)
        {
            ExceededCreditLimit?.Invoke(this, e);
        }

        protected virtual void OnPinChanged(AccountChangedEventArgs e)
        {
            PinChanged?.Invoke(this, e);
        }
    }

    // Класс для передачи информации о событии
    public class AccountChangedEventArgs : EventArgs
    {
        public string Message { get; set; }

        public AccountChangedEventArgs(string message)
        {
            Message = message;
        }
    }

}
