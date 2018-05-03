using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    interface IBankClerk
    {
        Account BankAccount { get; set; }
        ITxnManager BankManager { get; set; }
        ITransaction Deposit { get; set; }
        ITransaction Withdraw { get; set; }
        ITransaction AccountBalance { get; set; }
        void DoDeposit(double Amount);
        void DoWithdrawal(double Amount);
        void CheckAccount();
    }
    class BankClerk: IBankClerk
    {
        public Account BankAccount { get; set; }
        public ITxnManager BankManager { get; set; }
        public ITransaction Deposit { get; set; }
        public ITransaction Withdraw { get; set; }
        public ITransaction AccountBalance { get; set; }
        public BankClerk(int ID)
        {
            BankAccount = new Account(ID);
            BankManager = new TxnManager();
        }
        public void DoDeposit(double Amount)
        {
            Deposit = new Deposit(BankAccount, Amount);
            BankManager.AddTxn(Deposit);
            BankManager.ProcessTxn();
        }
        public void DoWithdrawal(double Amount)
        {
            Withdraw = new Withdraw(BankAccount, Amount);
            BankManager.AddTxn(Withdraw);
            BankManager.ProcessTxn();
        }
        public void CheckAccount()
        {
            AccountBalance = new AccountBalance(BankAccount);
            BankManager.AddTxn(AccountBalance);
            BankManager.ProcessTxn();
        }
    }
}
