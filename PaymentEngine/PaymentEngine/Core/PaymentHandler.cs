using System;
using System.Collections.Generic;

namespace PaymentEngine
{
    public class PaymentHandler
    {
        private readonly IList<IHandler<PaymentOrder>> handlers;
        
        public PaymentHandler(params IHandler<PaymentOrder>[] handlers)
        {
            this.handlers = handlers;
        }

        public void Handle(PaymentOrder order)
        {
            foreach (var handler in handlers)
            { 
                handler.Handle(order);
            }
        }

    }
}