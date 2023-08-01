using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private string cardNumber;
        private string cardHolderName;

        public CreditCardPaymentStrategy(string cardNumber, string cardHolderName)
        {
            this.cardNumber = cardNumber;
            this.cardHolderName = cardHolderName;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} TL with Credit Card (Card Number: {cardNumber}, Card Holder: {cardHolderName}).");
        }
    }
}
