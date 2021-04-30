namespace PaymentEngine
{
    public interface IHandler<T> where T : class
    {
        void Handle(T order);
    }
}



