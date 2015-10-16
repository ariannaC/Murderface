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
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Course course = new Course(int.Parse(txtCRN.Text), txtTitle.Text, int.Parse(ddDepartment.SelectedValue), ddSemester.SelectedValue, txtSectionNum.Text, txtProfessor.Text, ddTimeCode.SelectedValue, ddDayCode.SelectedValue, int.Parse(ddCreditHours.SelectedValue), int.Parse(txtMaxSeats.Text));
            course.SaveCourse();     
                     
        }
    }
}