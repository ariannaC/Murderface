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
        string empCode = "bananas1";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool inpputVal()
        {
            if (txtAccBal.Text == "" || txtCCNum.Text == "" ||  txtCode.Text == "" || txtCVV.Text == "" || txtFName.Text == ""
                || txtLimit.Text=="" || txtLName.Text=="")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please fill in all fields to submit a new course');</script>");
                return false;
            }

            try
            {
                int.Parse(txtCCNum.Text);
                int.Parse(txtCVV.Text);
                float.Parse(txtLimit.Text);
                float.Parse(txtAccBal.Text);
                return true;
            }
            catch
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please enter valid fields for CVV, Account Balance, Credit Limit, and Credit Card Number for the card you are trying to add.');</script>");
                return false;
            }

        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != empCode)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please enter the correct employee code');</script>");
                return;
            }

            if (inpputVal() == false)
            {
                return;
            }
            CreditCardServiceRef.TheWebService pxy = new CreditCardServiceRef.TheWebService();
            CreditCardServiceRef.CreditCardClass creditCard = new CreditCardServiceRef.CreditCardClass();
            CreditCardServiceRef.CustomerClass arthur = new CreditCardServiceRef.CustomerClass();
            DateTime dt = DateTime.Now;
            //Account Number generated uniquely each time using the date time stuff in c# to make a new 10 digit number each time a new card is added
            string accNum = dt.Month.ToString() + dt.Day.ToString() + dt.ToString("yy") + dt.Hour.ToString() + dt.Minute.ToString();
            creditCard.AccountNumber = float.Parse(accNum);
            creditCard.CVV = int.Parse(txtCVV.Text);
            creditCard.CardNumber = int.Parse(txtCCNum.Text);
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionsPage.aspx");
        }
    }
}
