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
           
           return (DB.DoUpdateUsingCmdObj(command)>0)? true: false;

        }

        [WebMethod]
        public bool UpdateCustomer(CustomerClass fred, CreditCardClass cc)
        {
            DBConnect DB = new DBConnect();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "CustomerUpdate";
            command.Parameters.AddWithValue("@FirstName", fred.Firstname);
            command.Parameters.AddWithValue("@Address", fred.Address);
            command.Parameters.AddWithValue("@City", fred.City);
            command.Parameters.AddWithValue("@State", fred.State);
            command.Parameters.AddWithValue("@ZipCode", fred.ZipCode);
            command.Parameters.AddWithValue("@AccountBalance", cc.AccountBalance);

            return (DB.DoUpdateUsingCmdObj(command) > 0) ? true : false;
        }

        [WebMethod]
        public float GetCreditLimit(string fName)
        {
            DBConnect DB = new DBConnect();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetCreditLimit";
            command.Parameters.AddWithValue("@FirstName", fName);
            DataSet ds = DB.GetDataSetUsingCmdObj(command);

            return float.Parse(ds.Tables[0].Rows[0]["CreditLimit"].ToString());
            
        }
    }
}
