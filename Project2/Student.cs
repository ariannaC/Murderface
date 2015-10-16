
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2
{
    public class Student
    {
        public int id;
        public string name;
        public float tuition;

        public Student(int id, string name, float tuition)
        {
            this.id = id;
            this.name = name;
            this.tuition = tuition;
        }

        public void saveStudent()
        {


        }
    }

}