using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace Project2
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect DB = new DBConnect();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetAdmin";

                DataSet ds = DB.GetDataSetUsingCmdObj(command);
                ddAdmin.DataSource = ds;
                ddAdmin.DataTextField = "Name";
                ddAdmin.DataValueField = "AdminID";
                ddAdmin.DataBind();

                ddAdmin.Items.Add(new ListItem("No Selection", "NoSelection"));
                ddAdmin.SelectedIndex = ddAdmin.Items.Count - 1;
                

                SqlCommand command2 = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetStudent";

                DataSet ds2 = DB.GetDataSetUsingCmdObj(command);
                ddStudent.DataSource = ds2;
                ddStudent.DataValueField = "StudentID";
                ddStudent.DataTextField = "Name";
                ddStudent.DataBind();
                ddStudent.Items.Add(new ListItem("No Selection", "NoSelection"));
                ddStudent.SelectedIndex = ddStudent.Items.Count - 1;
            }
        }

        public void isStudentSelected()
        {
            
        }

        public void isAdminSelected()
        {

        }

        protected void btnCourse_Click(object sender, EventArgs e)
        {

            if (ddStudent.SelectedItem.Text == "No Selection" && ddAdmin.SelectedItem.Text == "No Selection")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please chooose a login option to continue');</script>");
                
            }
            else Response.Redirect("NewCoursePage.aspx");


                
          
        }

        protected void btnNewStudent_Click(object sender, EventArgs e)
        {
            if (ddStudent.SelectedItem.Text == "No Selection" && ddAdmin.SelectedItem.Text == "No Selection")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please chooose a login option to continue');</script>");

            }
            else Response.Redirect("NewStudentPage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (ddStudent.SelectedItem.Text == "No Selection" && ddAdmin.SelectedItem.Text == "No Selection")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please chooose a login option to continue');</script>");

            }
           // isStudentSelected();
            else  Response.Redirect("BillingPage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ddStudent.SelectedItem.Text == "No Selection" && ddAdmin.SelectedItem.Text == "No Selection")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please chooose a login option to continue');</script>");

            }

            else   Response.Redirect("SearchPage.aspx");
        }

        protected void ddStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNewCourse.Enabled = false;
            btnNewStudent.Enabled = false;
            if (ddStudent.SelectedItem.Text == "No Selection")
            {
                btnNewStudent.Enabled = true;
                btnNewCourse.Enabled = true; 
            }
        }

        protected void ddAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddStudent.SelectedItem.Text == "No Selection")
            {
                btnNewStudent.Enabled = true;
                btnNewCourse.Enabled = true; 
            }
        }
    }
} 