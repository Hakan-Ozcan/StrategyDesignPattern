using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class BankTransferPaymentStrategy : IPaymentStrategy
    {
        private string accountNumber;
        private string accountHolderName;

        public BankTransferPaymentStrategy(string accountNumber, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} TL with Bank Transfer (Account Number: {accountNumber}, Account Holder: {accountHolderName}).");
        }
    }
}
