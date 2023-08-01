using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignPattern.Strategies;

namespace StrategyDesignPattern.Context
{
    public class ShoppingCart
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Checkout(int amount)
        {
            paymentStrategy.Pay(amount);
        }
    }
}
