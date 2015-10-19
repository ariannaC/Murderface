using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilities;

namespace Project2
{
    public partial class BillingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Student";
            DBConnect db = new DBConnect();
            ddStudentSelect.DataSource = db.GetDataSet(query);
            ddStudentSelect.DataValueField = "StudentID";
            ddStudentSelect.DataTextField = "Name";
            ddStudentSelect.DataBind();
        }
    }
}