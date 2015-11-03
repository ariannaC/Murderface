using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;
using System.Data;
using System.Data.SqlClient;


namespace Project3WS
{
    /// <summary>
    /// Summary description for TheWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TheWebService : System.Web.Services.WebService
    {
        //SQL RETURN VALUES FOR VERIFICATION:
        //1 = Success
        //2 = Credit card does not exist in database
        //3 = transaciton ammount exceeds credit limit
        //4 = incorrect CVV code 
        //5 = Incorrect first name for card 

        //dear pouya i liked the name of this method so i kept it. anyway it adds a new customer and new credit card to db
        [WebMethod]
        public bool HelloWorld(CreditCardClass cc, CustomerClass arthur)
        {
            DBConnect DB = new DBConnect();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddCard";
            command.Parameters.AddWithValue("@CreditCardNumber", cc.CardNumber);
            command.Parameters.AddWithValue("@CVV", cc.CVV);
            command.Parameters.AddWithValue("@AccountNumber", cc.AccountNumber);
            command.Parameters.AddWithValue("@CreditLimit", cc.CreditLimit);
            command.Parameters.AddWithValue("@AccountBalance", cc.AccountBalance);
            command.Parameters.AddWithValue("@FirstName", arthur.Firstname);
            command.Parameters.AddWithValue("@LastName", arthur.LastName);

            return (DB.DoUpdateUsingCmdObj(command) > 0) ? true : false;

        }

        [WebMethod]
        public string[] UpdateCustomer(CustomerClass fred, CreditCardClass cc, object[] stupid)
        {
            DBConnect DB = new DBConnect();
            SqlCommand command = new SqlCommand();
            string[] meh = new string[3];
            ErrorCodes ec = new ErrorCodes();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CustomerUpdate";
            command.Parameters.AddWithValue("@FirstName", fred.Firstname);
            command.Parameters.AddWithValue("@Address", fred.Address);
            command.Parameters.AddWithValue("@City", fred.City);
            command.Parameters.AddWithValue("@State", fred.State);
            command.Parameters.AddWithValue("@ZipCode", fred.ZipCode);
            command.Parameters.AddWithValue("@AccountBalance", cc.AccountBalance);
            meh[0] = (DB.DoUpdateUsingCmdObj(command) > 0) ? "true" : "false";
            SqlCommand sandy = new SqlCommand();
            sandy.CommandType = CommandType.StoredProcedure;
            sandy.CommandText = "VerifyInfo";
            sandy.Parameters.AddWithValue("@CreditCardNum", cc.CardNumber);
            sandy.Parameters.AddWithValue("@CVV", cc.CVV);
            sandy.Parameters.AddWithValue("@TransAmnt", float.Parse(stupid[2].ToString()));
            sandy.Parameters.AddWithValue("@FirstName", fred.Firstname);
            SqlParameter returnParam = new SqlParameter("@RVAL", DbType.Int32);
            returnParam.Direction = ParameterDirection.ReturnValue;
            sandy.Parameters.Add(returnParam);

//            DataSet ds = DB.GetDataSetUsingCmdObj(sandy);
            DB.GetDataSetUsingCmdObj(sandy);         
            meh[1] = sandy.Parameters["@RVAL"].Value.ToString();
            meh[2] = ec.GetErrorCodeMessage(int.Parse(meh[1]));
            
            
            return meh;
        }

        [WebMethod]
        public float GetCreditLimit(string fName)
        {
            try
            {
                DBConnect DB = new DBConnect();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetCreditLimit";
                command.Parameters.AddWithValue("@FirstName", fName);
                DataSet ds = DB.GetDataSetUsingCmdObj(command);

                return float.Parse(ds.Tables[0].Rows[0]["CreditLimit"].ToString());
            }

            catch
            {
                return 0;
            }
        }
    }
}
