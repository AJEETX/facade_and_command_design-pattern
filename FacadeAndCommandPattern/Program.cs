using System;

namespace CommandPattern
{
    class Program
    {
        static IBankCustomer customer;
        static void Main(string[] args)
        {
            customer = new BankCustomer(101);
            customer.Deposit(50);
            customer.Withdraw(25);
            customer.CheckAccount();
            Console.ReadKey();
        }
    }
}
