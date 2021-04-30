using PaymentEngine.PaymentProcessors;

namespace PaymentEngine.PaymentHandlers
{
    public class FidelityBankPaymentHandler : IHandler<PaymentOrder>
    {
        public FidelityBankPaymentProcessor fidelityBankPaymentProcessor { get; }
            = new FidelityBankPaymentProcessor();
        public void Handle(PaymentOrder order)
        {
            if (order.PaymentProvider == PaymentProvider.FidelityBank)
            {
                fidelityBankPaymentProcessor.ProcessPayment(order);
            }
        }
    }
}