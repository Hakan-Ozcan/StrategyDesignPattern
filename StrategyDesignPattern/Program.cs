using StrategyDesignPattern;

public class Program
{
    public static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        IPaymentStrategy creditCardPaymentStrategy = new CreditCardPaymentStrategy("1234-5678-9012-3456", "John Doe");
        cart.SetPaymentStrategy(creditCardPaymentStrategy);
        cart.Checkout(1000);

        IPaymentStrategy bankTransferPaymentStrategy = new BankTransferPaymentStrategy("TR12 3456 7890 1234 5678 9012", "Jane Smith");
        cart.SetPaymentStrategy(bankTransferPaymentStrategy);
        cart.Checkout(500);
    }
}