using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class AccountBalance : ITransaction
    {
        Account _account;
        public bool IsComplete { get ; set ; }
        public AccountBalance(Account account)
        {
            _account = account;IsComplete = false;
        }

        public void Transact()
        {
            Console.WriteLine($"#{_account.Description.ToUpper()} Account #{_account.ID} Balance: {_account.Balance}") ;
            IsComplete = true;
        }
    }
}
