using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewCoursePage.aspx");
        }

        protected void btnNewStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewStudentPage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("BillingPage.aspx");
        }
    }
}