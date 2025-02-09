using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Methods
{
    internal class PaymentProcessor
    {
        private IPayment_Methods _payment_Methods;
        public PaymentProcessor(IPayment_Methods payment_Methods )
        {
            payment_Methods = _payment_Methods;
        }
        public void ProcessPayment(decimal amount)
        {
            _payment_Methods.PaymentProsess(amount);
        }
    }
}
