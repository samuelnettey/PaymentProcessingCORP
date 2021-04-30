using System;

namespace PaymentEngine.PaymentProcessors
{
    public class FidelityBankPaymentProcessor: IPaymentProcessor
    {
        public void ProcessPayment(PaymentOrder order)
        {
            // TODO : PUT  Fidelity IMPLEMENTATION HERE
            Console.WriteLine("I'm processing Fidelity Bank Payment");
        }
    }
}