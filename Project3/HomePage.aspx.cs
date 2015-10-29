using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountsPage.aspx");
        }

        protected void btnTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionsPage.aspx");
        }
    }
}