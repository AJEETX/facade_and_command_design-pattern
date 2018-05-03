using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CommandPattern
{
    interface ITxnManager
    {
        void AddTxn(ITransaction txn);
        void ProcessTxn();
    }
    class TxnManager: ITxnManager
    {
        static IList<ITransaction> txns = new List<ITransaction>();
        public void AddTxn(ITransaction txn)
        {
            txns.Add(txn);
        }
        public void ProcessTxn()
        {
            foreach (var txn in txns.Where(t=>!t.IsComplete))
                txn.Transact();
        }
    }
}
