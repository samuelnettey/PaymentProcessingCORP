using System;

namespace PaymentEngine.PaymentProcessors
{
    public class StandbicBankPaymentProcessor: IPaymentProcessor
    {
        public void ProcessPayment(PaymentOrder order)
        {
            // TODO : PUT  Standbic IMPLEMENTATION HERE
            Console.WriteLine("I'm processing  Standbic Bank Payment");
        }
    }
}