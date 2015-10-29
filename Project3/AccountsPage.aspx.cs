using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3
{
    public partial class AccountsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            CreditCardServiceRef.TheWebService pxy = new CreditCardServiceRef.TheWebService();
            CreditCardServiceRef.CreditCardClass creditCard = new CreditCardServiceRef.CreditCardClass();
            CreditCardServiceRef.CustomerClass arthur = new CreditCardServiceRef.CustomerClass();
            DateTime dt = DateTime.Now;
            //Account Number generated uniquely each time using the date time stuff in c# to make a new 10 digit number each time a new card is added
            string accNum = dt.Month.ToString() + dt.Day.ToString() + dt.ToString("yy") + dt.Hour.ToString() + dt.Minute.ToString();
            creditCard.AccountNumber = float.Parse(accNum);
            creditCard.CVV = int.Parse(txtCVV.Text);
            creditCard.CardNumber = float.Parse(txtCCNum.Text);
            creditCard.CreditLimit = float.Parse(txtLimit.Text);
            creditCard.AccountBalance = float.Parse(txtAccBal.Text);
            arthur.Firstname = txtFName.Text;
            arthur.LastName = txtLName.Text;
            pxy.HelloWorld(creditCard, arthur);
            
           
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}
