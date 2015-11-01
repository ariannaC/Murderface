using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3WS
{
    public class ErrorCodes
    {
        public Dictionary<int, string> errorCodes;

        public ErrorCodes()
        {
            errorCodes = new Dictionary<int, string>();
            errorCodes.Add(1,"Success");
            errorCodes.Add(3, "Transaction amount exceeds credit limit");
            errorCodes.Add(2,"Invalid Card Number");
            errorCodes.Add(4,"Invalid CVV code");
            errorCodes.Add(5, "Name does not match card");
            
        }

        public string GetErrorCodeMessage(int code)
        {
            return errorCodes[code];
        }
    }
}