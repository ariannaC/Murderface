
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Utilities;


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
            this.tuition = 0;
        }

        public void saveStudent()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "NewStudent";
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Tuition", tuition);
            DBConnect DB = new DBConnect();
            DB.DoUpdateUsingCmdObj(command);

        }
    }

}