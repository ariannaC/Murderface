using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Project1
{
    public partial class Build_A_Bar : System.Web.UI.Page
    {
        List<CarOption> selectedPackages = new List<CarOption>();
        DBConnect myConnect = new DBConnect();
        Car localCar; 


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect myConnect = new DBConnect();
                string strSQL = "SELECT DISTINCT CarMake FROM Cars";
                DataSet myDataSet = myConnect.GetDataSet(strSQL);

                ddlMake.DataSource = myDataSet;
                ddlMake.DataTextField = "CarMake";
                ddlMake.DataValueField = "CarMake";
                ddlMake.DataBind();
                ddlMake.Items.Add(new ListItem("No Selection", "NoSelection"));
                ddlMake.SelectedIndex = ddlMake.Items.Count - 1;
                ddlModel.Items.Add(new ListItem("No Make Selected", "NoMakeSelect"));
                string delete = "DELETE FROM SelectedPackages";
                myConnect.DoUpdate(delete);
            }
        }

        protected void ddlMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string SelectedCarMake = ddlMake.SelectedValue;
            if (SelectedCarMake != "NoSelection")
            {
                DBConnect myConnect = new DBConnect();
                string strSQL = "SELECT CarModel FROM Cars WHERE CarMake = '" + SelectedCarMake + "'";
                DataSet myDataSet = myConnect.GetDataSet(strSQL);

                ddlModel.DataSource = myDataSet;
                ddlModel.DataTextField = "CarModel";
                ddlModel.DataValueField = "CarModel";
                ddlModel.DataBind();


                string strsql2 = "SELECT PackageDescription, Price, PackageID FROM Packages";
                DataSet myDS2 = myConnect.GetDataSet(strsql2);
                gvPackages.DataSource = myDS2;
                gvPackages.DataBind();
            }
            else
            {
                ddlModel.Items.Clear();
                ddlModel.DataBind();
                ddlModel.Items.Add(new ListItem("No Make Selected", "NoMakeSelect"));
                
            }
        }

        protected void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            float totalCost = 0;
            if (txtName.Text == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Enter Your Name');</script>");
            }

            else if (txtPhone.Text == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Enter Your Phone Number');</script>");
            }

            else if (txtAddress1.Text == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Enter Your Current Address');</script>");
            }

            else if (txtCity.Text == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Enter the City of Your Above Address');</script>");
            }

            else if (txtState.Text == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Enter the State of Your Above Address');</script>");
            }

            else if (txtZip.Text == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Enter the Zip Code for Your Above Address');</script>");
            }

            else if (ddlMake.Text == "No Selection")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You Must Select a Make and Model to Begin Building Your Car');</script>");
            }

           /* else if (selectedPackages.Count==0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You Must Pick at Least One Package for Your Car');</script>");
            }
            */
            else if (ddlColor.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Choose a Color for Your Car or It will Look Like Crap');</script>");
            }

            else if (rdbBuy.Checked == true)
            {
                rdbLease.Enabled = false;
                if (rdbBuy.Checked == false)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Choose a Payment Option');</script>");
                }
            }

            else if(rdbLease.Checked==true)
            {
                rdbBuy.Enabled = false;
                if (rdbLease.Checked == false)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Choose a Payment Option');</script>");
                }
            }
            else if (rdbCall.Checked == true)
            {
                rdbDealership.Enabled = false;
                if (rdbCall.Checked == false)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Choose a Follow Up Option');</script>");
                }
            }
            else if (rdbDealership.Checked == true)
            {
                rdbCall.Enabled = false;
                if (rdbDealership.Checked == false)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please Choose a Follow Up Option');</script>");
                }
            }
            else
            {
                gvPackages.Enabled = false;
                ddlMake.Enabled = false;
                ddlModel.Enabled = false;
                ddlColor.Enabled = false;
                Processor P = new Processor();
                string carName = ddlModel.Text;

                string sqlYear = "SELECT CarYear FROM Cars WHERE CarModel ='" + carName + "'";
                DataSet yearDS = myConnect.GetDataSet(sqlYear);
             //   DataRow DR =  myConnect.GetRow(yearDS, 0);
                int year = int.Parse(yearDS.Tables[0].Rows[0]["CarYear"].ToString());
                

             localCar = new Car(ddlMake.Text, ddlModel.Text, year, selectedPackages, ddlColor.Text);
             totalCost = P.getTotalCost(localCar);

             //Label1.Text = totalCost.ToString();

             gvOutput.DataSource = P.Greg(localCar);
             gvOutput.DataBind();
            }
            string output = "SELECT * FROM SelectedPackages";
            DataSet outputDS = myConnect.GetDataSet(output);
            gvOutput.DataSource = outputDS;
            gvOutput.DataBind();
          //  gvOutput.Columns[0].FooterText = "Total cost: ";
           // gvOutput.Columns[2].FooterText = " " + totalCost;
    //     string q = "SELECT SUM(PackagePrice) AS PackagePrice FROM SelectedPackages";
    //     DataSet k = myConnect.GetDataSet(q);
    //     totalCost = float.Parse(k.Tables[0].Rows[0]["PackagePrice"].ToString()) + localCar.TotalPrice;
     //       Label4.Text = "Total Cost:  " + totalCost;
           

            lblOutName.Text = txtName.Text;
            lblOutPhone.Text = txtPhone.Text;
            lblOutMake.Text = ddlMake.Text;
            lblOutModel.Text = ddlModel.Text + " in " + ddlColor.Text;
            if (rdbBuy.Checked == true && rdbCall.Checked == true)
            {
                lblOtherOptions.Text = rdbBuy.Text + " and " + rdbCall.Text;
                
            }
            else if (rdbBuy.Checked == true && rdbDealership.Checked == true)
            {
                lblOtherOptions.Text = rdbBuy.Text +" and " + rdbDealership.Text;
            }
            if (rdbLease.Checked == true && rdbCall.Checked == true)
            {
                lblOtherOptions.Text = rdbLease.Text + " and " + rdbCall.Text;

            }
            else if (rdbLease.Checked == true && rdbDealership.Checked == true)
            {
                lblOtherOptions.Text = rdbLease.Text + " and " + rdbDealership.Text;
            }
        }

        protected void gvPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gvPackages.SelectedRow == gvPackages.Rows[0])
            {
                
                Button poop = (Button)gvPackages.SelectedRow.Cells[0].Controls[0];
                if (poop.Text == "Add")
                {
                    CarOption p = new CarOption(gvPackages.SelectedRow.Cells[1].Text, float.Parse(gvPackages.SelectedRow.Cells[2].Text));
                    p.PackPrice = float.Parse(gvPackages.SelectedRow.Cells[2].Text);
                    p.ID = int.Parse(gvPackages.SelectedRow.Cells[3].Text);
                    selectedPackages.Add(p);
                    poop.Text = "Undo";
                    string sqlQuery = "INSERT INTO SelectedPackages VALUES(" + 1 + ", '" + p.PackDesc + "', '" + p.PackPrice + "')";
                    myConnect.DoUpdate(sqlQuery);
                }
                else if (poop.Text == "Undo")
                {
                    
                    CarOption p = new CarOption(gvPackages.SelectedRow.Cells[1].Text, float.Parse(gvPackages.SelectedRow.Cells[2].Text));
                    selectedPackages.Remove(p);
                    poop.Text = "Add";
                }

                
                
            }

            else if (gvPackages.SelectedRow == gvPackages.Rows[1])
            {
                Button poop = (Button)gvPackages.SelectedRow.Cells[0].Controls[0];
                if (poop.Text == "Add")
                {
                    
                    CarOption p = new CarOption(gvPackages.SelectedRow.Cells[1].Text, float.Parse(gvPackages.SelectedRow.Cells[2].Text));
  
                    p.ID = 2;
                
               
                 p.PackPrice = float.Parse(gvPackages.SelectedRow.Cells[2].Text);

                 string sqlQuery = "INSERT INTO SelectedPackages VALUES(" + 2 + ", '" + p.PackDesc + "', '" + p.PackPrice + "')";

                    poop.Text = "Undo";   
                }
                else if (poop.Text == "Undo")
                {
                    CarOption p = new CarOption(gvPackages.SelectedRow.Cells[1].Text, float.Parse(gvPackages.SelectedRow.Cells[2].Text));
                    selectedPackages.Remove(p);
      
                    poop.Text = "Add";
                }

            }

            else
            {
                Button poop = (Button)gvPackages.SelectedRow.Cells[0].Controls[0];
                if (poop.Text == "Add")
                {
                    CarOption p = new CarOption(gvPackages.SelectedRow.Cells[1].Text, float.Parse(gvPackages.SelectedRow.Cells[2].Text));
                    p.ID = int.Parse(gvPackages.SelectedRow.Cells[3].Text);
                    selectedPackages.Add(p);
                    hfSelectedPackages.Value += p.ID;
                    p.PackPrice = float.Parse(gvPackages.SelectedRow.Cells[2].Text);
                    p.ID = int.Parse(gvPackages.SelectedRow.Cells[3].Text);
                    string sqlQuery = "INSERT INTO SelectedPackages VALUES(" + 3 + ", '" + p.PackDesc + "', '" + p.PackPrice + "')";
                    myConnect.DoUpdate(sqlQuery);

                    poop.Text = "Undo";
                }
                else if (poop.Text == "Undo")
                {
                    CarOption p = new CarOption(gvPackages.SelectedRow.Cells[1].Text, float.Parse(gvPackages.SelectedRow.Cells[2].Text));
                    selectedPackages.Remove(p);

                    poop.Text = "Add";
                }
            }
            
           
        }

        protected void gvPackages_RowEditing(object sender, GridViewEditEventArgs e)
        {
           
        }

        protected void gvPackages_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Build_A_Bar.aspx");
        }
    }
}