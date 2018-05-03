using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Account
    {
        public int ID { get; private set; }
        public string Description { get; set; } = "Savings";
        public double Balance { get; set; } = 333;
        public Account(int Id)
        {
            ID = Id;
        }
    }
    interface ITransaction
    {
        bool IsComplete { get; set; }
        void Transact();
    }
}
