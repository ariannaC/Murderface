using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3WS
{
    [Serializable]
    public class CustomerClass
    {
        public int CustomerID;
        public string Firstname;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string ZipCode;
    }
}