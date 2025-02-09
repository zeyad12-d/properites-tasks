namespace Assignment_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccounts myAccount = new BankAccounts(" 13333 ", "engZeyad", 8000);

            myAccount.depost(1000);
            myAccount.wihdraw(9000);
           
            myAccount.dispaly();
            Console.ReadKey();

        }
    }
}