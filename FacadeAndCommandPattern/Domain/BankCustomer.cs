using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    interface IBankCustomer {
        void Deposit(double depositAmount);
        void Withdraw(double withdrawAmount);
        void CheckAccount();
    }
    class BankCustomer: IBankCustomer
    {
        IBankClerk clerk;
        public BankCustomer(int ID)
        {
            clerk = new BankClerk(ID);
        }
        public void Deposit(double depositAmount)
        {
            clerk.DoDeposit(depositAmount);
        }
        public void Withdraw(double withdrawAmount)
        {
            clerk.DoWithdrawal(withdrawAmount);
        }
        public void CheckAccount()
        {
            clerk.CheckAccount();
        }
    }
}
