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
            object[] stupid = new object[10];
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
            creditCard.CardNumber = int.Parse(txtCCNum.Text);
            creditCard.CVV = int.Parse(txtCVV.Text);
            stupid[0] = creditCard.CardNumber;
            stupid[1] = creditCard.CVV;
            stupid[2] = float.Parse(TxtTransAmnt.Text);
            stupid[3] = fred.Firstname;
            string[] blah = pxy.UpdateCustomer(fred, creditCard, stupid);

            txtErrors.Text = blah[2];
            
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}