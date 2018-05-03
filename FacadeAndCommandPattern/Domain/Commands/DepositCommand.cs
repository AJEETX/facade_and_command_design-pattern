using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Deposit : ITransaction
    {
        Account account; double depositAmount;
        public Deposit(Account acc, double Amount)
        {
            account = acc;
            depositAmount = Amount;
            IsComplete = false;
        }
        public bool IsComplete { get; set; }
        public void Transact()
        {
            Console.WriteLine($"The account #{account.ID} balance before Deposit of amount ${depositAmount }: {account.Balance}");
            account.Balance = account.Balance + depositAmount;
            Console.WriteLine($"The account #{account.ID} balance after Deposit: {account.Balance }");
            IsComplete = true;
        }
    }
}
