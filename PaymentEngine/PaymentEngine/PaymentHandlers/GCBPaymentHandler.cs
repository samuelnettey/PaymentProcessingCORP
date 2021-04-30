using PaymentEngine.PaymentProcessors;

namespace PaymentEngine.PaymentHandlers
{
    public class GCBPaymentHandler: IHandler<PaymentOrder>
    {
        public GCBPaymentProcessor gCBPaymentProcessor { get; }
            = new GCBPaymentProcessor();
        public void Handle(PaymentOrder order)
        {
            if (order.PaymentProvider == PaymentProvider.GCB)
            {
                gCBPaymentProcessor.ProcessPayment(order);
            }
        }
    }
}
