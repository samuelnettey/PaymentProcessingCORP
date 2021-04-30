using System;
using PaymentEngine.PaymentHandlers;

namespace PaymentEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            // THis order will be the model from the frontend containing all necessary information
            PaymentOrder order = new PaymentOrder();
            order.PaymentProvider = PaymentProvider.FidelityBank;
             
            var handler = new PaymentHandler(
                new GCBPaymentHandler(),
                new FidelityBankPaymentHandler(), 
                new StandbicBankPaymentHandler()
            );

            handler.Handle(order);
        }
    }
}
