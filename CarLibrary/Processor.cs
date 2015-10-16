using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;



namespace Project1
{
    
    public class Processor
    {
       DBConnect connect = new DBConnect();
       Car c;
       CarOption co;

       public Processor()
       {

       }
          
        public float getTotalCost(Car car)
        {
            string sqlBasePrice = "SELECT BasePrice FROM Cars WHERE CarModel='" + car.Model + "'";
            DataSet priceDS = connect.GetDataSet(sqlBasePrice);
            car.TotalPrice = float.Parse(priceDS.Tables[0].Rows[0]["BasePrice"].ToString());
            List<CarOption> cartman = car.Packages;
            float pkgPrice= car.TotalPrice;
            for(int i = 0; i< cartman.Count; i++)
            {
                CarOption currentPkg = cartman[i];
                pkgPrice += currentPkg.PackPrice;
            }
            
        //    String sqlPkgPrice = "SELECT Price FROM Packages WHERE CarID='" + CarID + "'";

            return pkgPrice;
        }
        public void updateCarQuantitySold(String CarID)
        {
            String sqlQuantSold = "UPDATE Cars SET TotalQuantitySold = TotalQuantitySold + 1 WHERE CarID ='" + CarID + "'";
            DataSet myDataSet = connect.GetDataSet(sqlQuantSold);
        }

        public void updateTotalSales(String CarID)
        {
            String sqlTotalSales = "UPDATE Cars SET TotalSales = TotalSales + BasePrice WHERE CarID ='" + CarID + "'";
            DataSet myDS = connect.GetDataSet(sqlTotalSales);
        }

        public DataSet Greg(Car c)
        {
            DataTable table1 = new DataTable("Output");
            table1.Columns.Add("Selected Packages");
            table1.Columns.Add("Price");

            for (int i = 0; i < c.Packages.Count; i++)
            {
                CarOption currentPkg = c.Packages[i];
                table1.Rows.Add(currentPkg.PackDesc, currentPkg.PackPrice);
            }

            DataSet outputDS = new DataSet("Greg");
            outputDS.Tables.Add(table1);

            return outputDS;

        }

/*
       public float getTotalPrice(Car c)
       {
           string sqlPrice = "SELECT * FROM Cars WHERE CarID =" + c.ID;
           DataSet myDS2 = connect.GetDataSet(sqlPrice);
           connect.DoUpdate(sqlPrice);
           float tp = c.TotalPrice;
        //   tp = float.Parse(sqlPrice);
           return tp;
*/
           
       }

    }
