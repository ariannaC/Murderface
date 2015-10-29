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
        string clear = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        public bool inputVal()
        {
            if (txtName.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please enter the name of the student to continue.');</script>");
                return false;
            }

            try
            {
                int.Parse(TxtID.Text);
                return true;
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please enter a valid number for the student ID to continue.');</script>");
                return false;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (inputVal() == false)
            {
                return;
            }
            Student student = new Student(int.Parse(TxtID.Text), txtName.Text, 0);
            student.saveStudent();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('New student has been added successfully:).');</script>");
            txtName.Text = clear;
            TxtID.Text = clear;
        }
    }
}