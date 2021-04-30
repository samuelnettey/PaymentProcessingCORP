using PaymentEngine.PaymentProcessors;

namespace PaymentEngine.PaymentHandlers
{
    public class StandbicBankPaymentHandler: IHandler<PaymentOrder>
    {
        public StandbicBankPaymentProcessor standbicBankPaymentProcessor { get; }
            = new StandbicBankPaymentProcessor();
        public void Handle(PaymentOrder order)
        {
            if (order.PaymentProvider == PaymentProvider.Stanbic)
            {
                standbicBankPaymentProcessor.ProcessPayment(order);
            }
        }
    }
}