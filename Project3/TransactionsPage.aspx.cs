using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3
{
    public partial class TransactionsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            CreditCardServiceRef.TheWebService pxy = new CreditCardServiceRef.TheWebService();
            CreditCardServiceRef.CreditCardClass creditCard = new CreditCardServiceRef.CreditCardClass();
            CreditCardServiceRef.CustomerClass fred = new CreditCardServiceRef.CustomerClass();
            fred.Firstname = txtFName.Text;
            fred.LastName = txtLName.Text;
            fred.Address = txtAddress.Text;
            fred.City = txtCity.Text;
            fred.State = TextState.Text;
            fred.ZipCode = TxtZip.Text;
            creditCard.CreditLimit = pxy.GetCreditLimit(fred.Firstname);
            creditCard.AccountBalance = creditCard.CreditLimit - float.Parse(TxtTransAmnt.Text);
            pxy.UpdateCustomer(fred, creditCard);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}