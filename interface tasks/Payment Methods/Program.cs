namespace Payment_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a payment method: \n1. Credit Card \n2. Bank Transfer \n3. PayPal");
            string input = Console.ReadLine();
            Console.Write("inter amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            switch (input)
            {
                case "1":
                    IPayment_Methods creditCardPayment = new CreditCardPayment();
                    PaymentProcessor paymentProcessor = new PaymentProcessor(creditCardPayment);
                    paymentProcessor.ProcessPayment(amount);
                    
                    break;
                case "2":
                    IPayment_Methods bankTransfer = new BankTransefer();
                    PaymentProcessor paymentProcessor2 = new PaymentProcessor(bankTransfer);
                    paymentProcessor2.ProcessPayment(amount);
                    
                    break;
                case "3":
                    IPayment_Methods payPalPayment = new PayPalPayment();
                    PaymentProcessor paymentProcessor3 = new PaymentProcessor(payPalPayment);
                    paymentProcessor3.ProcessPayment(amount);
                   
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine("process is done");
        }
    }
}
