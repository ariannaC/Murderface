using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3WS
{
    public class ErrorCodes
    {
        public Dictionary<string, int> errorCodes;

        public ErrorCodes()
        {
            errorCodes = new Dictionary<string, int>();
            errorCodes.Add("Transaction amount exceeds credit limit", 01);
            errorCodes.Add("Invalid Card Number", 02);
            errorCodes.Add("Invalid CVV code", 03);

        }
    }
}