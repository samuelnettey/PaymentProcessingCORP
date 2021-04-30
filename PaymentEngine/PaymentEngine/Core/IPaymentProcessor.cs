namespace PaymentEngine
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(PaymentOrder order);
    }
}