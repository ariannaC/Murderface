using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Project1
{
    public class Car
    {
        private string make;
        private string model;
        private string color;
        private int year;
        private float totalPrice;
        private List<CarOption> packages;
        private int id;
        private int count;

        public Car()
        {
            packages = new List<CarOption>();
        }

        public Car(string make, string model, int y, List<CarOption> packages, string color)
        {
            this.packages = packages;
            this.make = make;
            this.model = model;
            this.year = y;
            this.packages = packages;
            this.color = color;
        }
        public int ID
        {
            get { return id; }
            set { value = id; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public void Add(CarOption pItem)
        {
           packages.Add(pItem);
           count = packages.Count;
           count++;

        }

        public void Remove(CarOption pItem)
        {
            packages.Remove(pItem);
            count = packages.Count;
            count--;
        }

        public Car GetCar(Car c)
        {
            return c;
        }

        public List<CarOption> Packages
        {
            get { return packages; }
        }
    }
}