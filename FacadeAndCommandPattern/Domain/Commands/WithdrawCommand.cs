using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Withdraw : ITransaction
    {
        Account account; double withdrawAmount;
        public Withdraw(Account acc, double Amount)
        {
            account = acc;
            withdrawAmount = Amount;
            IsComplete = false;
        }
        public bool IsComplete { get; set; }
        public void Transact()
        {
            if (account.Balance >= withdrawAmount)
            {
                Console.WriteLine($"The account #{account.ID} balance before withdrawal of amount ${withdrawAmount}: {account.Balance}");
                account.Balance = account.Balance - withdrawAmount;
                Console.WriteLine($"The account #{account.ID} balance after withdrawal: {account.Balance }");
                IsComplete = true;
            }
            else
                Console.WriteLine($"Account #{account.ID} balance is Low !!!");
        }
    }
}
