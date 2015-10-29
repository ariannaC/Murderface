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
    public partial class BillingPage : System.Web.UI.Page
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

            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void ddStudentSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnViewBill_Click(object sender, EventArgs e)
        {
                int studID = int.Parse(ddStudentSelect.SelectedValue.ToString());
                DBConnect db = new DBConnect();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetBill";
                command.Parameters.AddWithValue("@StudentID", studID);
                gvBill.DataSource = db.GetDataSetUsingCmdObj(command);
                gvBill.DataBind();
                int total = 0;
            for (int row = 0; row < gvBill.Rows.Count; row++)
            {
                total += int.Parse(gvBill.Rows[row].Cells[5].Text);
            }
            gvBill.FooterRow.Cells[1].Text = "Total Due: ";
            gvBill.FooterRow.Cells[5].Text = "$" + total;
            }
            

            }
        }
    
