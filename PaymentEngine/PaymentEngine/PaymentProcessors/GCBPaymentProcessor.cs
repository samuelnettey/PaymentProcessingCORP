using System;

namespace PaymentEngine.PaymentProcessors
{
    public class GCBPaymentProcessor: IPaymentProcessor
    {
        public void ProcessPayment(PaymentOrder order)
        {
           // TODO : PUT GCB IMPLEMENTATION HERE
           Console.WriteLine("I'm processing GCB Bank Payment");
        }
    }
}