using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3WS
{
    [Serializable]
    public class TransactionClass
    {
        public int TransactionID;
        public int CustomerID;
        public int CCID;
        public float Total;

    }
}