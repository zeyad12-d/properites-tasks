using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment_properties
{
    internal class BankAccounts
    {
        public string AccountNamber { get; }
        public string AcountHolderName { get; set; }

        public decimal Balance { get; private set; }


        //public int GETaccountNamber(int accountNamber)
        //{
        //    return AccountNamber=accountNamber;
        //}
        //public int GETbalance(int bal) { return Balance=Balance; }

        public BankAccounts(string ANumber, string AHolderName, decimal intiBalance)
        {
            if (intiBalance < 0)
            {
                Console.WriteLine("invaled balance please inter again");
            }
            else
            {
                Balance = intiBalance;
            }
            AccountNamber = ANumber;
           AcountHolderName = AHolderName;

        }

        public void dispaly() 
        { 
        Console.WriteLine($"this Account number\n={AccountNamber}\nand the Account holder number \n={AcountHolderName}\nbalance in Account \n={Balance}");
        }
        // ايداع
        public void depost(decimal amount)
        {
            if (amount > 0)
            {
                Balance +=amount;
            }
            else
            {
                Console.WriteLine($"cant add this amount to accountBalance = {amount}");
            }
        }
        //سحب 
        public void wihdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"transaction is done your amount={amount} and a new balance is {Balance}");
            }
            else if (Balance < amount)
            {
                Console.WriteLine($"unvaild transsaction your balance={Balance}");

            }
            else
            {
                Console.WriteLine(" مفيش فلوس يعمنا ");
            }
        }
    }
}
