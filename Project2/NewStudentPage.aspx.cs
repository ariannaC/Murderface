using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities; 

namespace Project2
{
    public partial class NewStudentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student(int.Parse(TxtID.Text), txtName.Text, 0);
            student.saveStudent();
        }
    }
}