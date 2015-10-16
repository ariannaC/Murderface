using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
//using Conneciton.cs;
namespace Project1
{
    public class CarOption
    {
      //  DBConnect opConnect = new DBConnect();
       private string packDesc;
       private float packPrice;
       private int quantSold;
       private int id;

       public CarOption(string pDesc, float price)
       {
           this.packDesc = pDesc;
           this.packPrice = price;
           
       }

       public int ID
       {
           get { return id; }
           set { value = id; }
       }

       public float PackPrice
       {
           get { return packPrice; }
           set { packPrice = value; }
       }

       public string PackDesc
       {
           get { return packDesc; }
           set { value = packDesc; }
       }

       public int QuantSold
       {
           get { return quantSold; }
           set { value = quantSold; }
       }
        
        

    }

    
}