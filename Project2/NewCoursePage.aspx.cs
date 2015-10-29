using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilities;
using System.Data.SqlClient;

namespace Project2
{
    public partial class NewCoursePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect DB = new DBConnect();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetDep";
                
                DataSet ds = DB.GetDataSetUsingCmdObj(command);
                ddDepartment.DataSource = ds;
                ddDepartment.DataTextField = "DepartmentName";
                ddDepartment.DataValueField = "DepartmentID";
                ddDepartment.DataBind();
            }
        }

        public bool inpputVal()
        {
            if (txtCRN.Text == "" || txtMaxSeats.Text == "" || txtProfessor.Text == "" || txtSectionNum.Text == "" || txtTitle.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please fill in all fields to submit a new course');</script>");
                return false;
            }

            try
            {
                int.Parse(txtCRN.Text);
                int.Parse(txtMaxSeats.Text);
                int.Parse(txtSectionNum.Text);
                return true;
            }
            catch
            {
                
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please enter valid fields for CRN, Maximum seats available, and the seciton number of the course you are trying to add.');</script>");
                return false;
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (inpputVal() == false)
            {
                return;
            }
           
            string clear = "";
            Course course = new Course(int.Parse(txtCRN.Text), txtTitle.Text, int.Parse(ddDepartment.SelectedValue), ddSemester.SelectedValue, txtSectionNum.Text, txtProfessor.Text, ddTimeCode.SelectedValue, ddDayCode.SelectedValue, int.Parse(ddCreditHours.SelectedValue), int.Parse(txtMaxSeats.Text));
            course.SaveCourse();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Your course has been added successfully:)');</script>");
            txtCRN.Text = clear;
            txtMaxSeats.Text = clear;
            txtProfessor.Text = clear;
            txtSectionNum.Text = clear;
            txtTitle.Text = clear;
            //  Response.Redirect("NewCoursePage.aspx");
        }
    }
}