using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Project2
{
    public partial class SearchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string query = "SELECT * FROM Student";
                DBConnect db = new DBConnect();
                ddStudentSelect.DataSource = db.GetDataSet(query);
                ddStudentSelect.DataValueField = "StudentID";
                ddStudentSelect.DataTextField = "Name";
                ddStudentSelect.DataBind();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetAllCourses";
                gvCourses.DataSource = db.GetDataSetUsingCmdObj(command);
                gvCourses.DataBind();
               
                for(int r = 0; r<gvCourses.Rows.Count; r++)
                {
                    CheckBox cb;
                    cb = (CheckBox)gvCourses.Rows[r].FindControl("cbSelectCourse");
                    if (int.Parse(gvCourses.Rows[r].Cells[10].Text) == 0)
                    {
                        cb.Enabled = false;
                    }
                }
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        public void rebind()
        {
            DBConnect db = new DBConnect();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetAllCourses";
            gvCourses.DataSource = db.GetDataSetUsingCmdObj(command);
            gvCourses.DataBind();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string title = "";
            string name = ddStudentSelect.SelectedItem.Text;
            int studentID = int.Parse(ddStudentSelect.SelectedValue);
            int checkedBoxCount = 0;
            for (int row = 0; row < gvCourses.Rows.Count; row++)
            {
                CheckBox CBox;
                CBox = (CheckBox)gvCourses.Rows[row].FindControl("cbSelectCourse");

                if (CBox.Checked)
                {
                
                  //  string courseCRN = gvCourses.Rows[row].Cells[1].Text;
                    int crn = int.Parse(gvCourses.Rows[row].Cells[1].Text);
                    float price = 1000 * int.Parse(gvCourses.Rows[row].Cells[9].Text);
                    title = gvCourses.Rows[row].Cells[2].Text;
                    Course c = new Course(crn, title, int.Parse(gvCourses.Rows[row].Cells[3].Text), gvCourses.Rows[row].Cells[4].Text, gvCourses.Rows[row].Cells[5].Text, gvCourses.Rows[row].Cells[6].Text, gvCourses.Rows[row].Cells[7].Text, gvCourses.Rows[row].Cells[8].Text, int.Parse(gvCourses.Rows[row].Cells[9].Text), int.Parse(gvCourses.Rows[row].Cells[11].Text));
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CourseRegistration";
                    command.Parameters.AddWithValue("@CRN", crn);
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Price", price);
                    DBConnect DB = new DBConnect();
                    DB.DoUpdateUsingCmdObj(command);
                    if (c.DecrementSeats() == -1)
                    {
                        gvCourses.Rows[row].Cells[0].Enabled = false;
                    }
                    c.DecrementSeats();
                    rebind();

                    checkedBoxCount++;
                }
            }
        }
        
    }
}