using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Methods
{
    internal class BankTransefer : IPayment_Methods
    {
        public void PaymentProsess(decimal amount)
        {
            Console.WriteLine("Bank Transfer Payment Processed: " + amount);
        }
    }   
    
    
}
