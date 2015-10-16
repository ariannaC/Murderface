using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace Project2
{
    public class Course
    {
        private int crn;
        private string title; 
        private int departmentID;
        private string semester;
        private string section;
        private string professor;
        private string timeCode;
        private string dayCode;
        private int creditHrs;
        private int numSeats;
        private int maxSeats;

        public Course(int crn, string title, int depID, string semester, string section, string prof, string tc, string dc, int ch, int ms)
        {
            this.crn = crn;
            this.title = title;
            this.departmentID = depID;
            this.semester = semester;
            this.section = section;
            this.professor = prof;
            this.timeCode = tc;
            this.dayCode = dc;
            this.creditHrs = ch;
          
            this.maxSeats = ms;
            this.numSeats = maxSeats;
        }
        public int CRN
        {
            get { return crn; }
            set { value = crn; }
        }

        public int DepartmentID
        {
            get { return departmentID; }
            set { value = departmentID; }
        }

        public string Title
        {
            get { return title; }
            set { value = title; }
        }

        public string Semester
        {
            get { return semester; }
            set { value = semester; }
        }

        public string Section
        {
            get { return section; }
            set { value = section; }
        }

        public string Prof
        {
            get { return professor; }
            set { value = professor; }
        }

        public string TimeCode
        {
            get { return timeCode; }
            set { value = timeCode; }
        }

        public string DayCode
        {
            get { return dayCode; }
            set { value = dayCode; }
        }

        public int CreditHours
        {
            get { return creditHrs; }
            set { value = creditHrs; }
        }

        public int NumberSeats
        {
            get { return numSeats; }
            set { value = numSeats; }
        }

        public int MaxSeats
        {
            get { return maxSeats; }
            set { value = maxSeats; }
        }

        public void SaveCourse()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "NewCourse";
            command.Parameters.AddWithValue("@CRN", crn);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@DepID", departmentID);
            command.Parameters.AddWithValue("@Semester", semester);
            command.Parameters.AddWithValue("@Section", section);
            command.Parameters.AddWithValue("@Professor", professor);
            command.Parameters.AddWithValue("@DayCode", dayCode);
            command.Parameters.AddWithValue("@TimeCode", timeCode);
            command.Parameters.AddWithValue("@CreditHrs", creditHrs);
      //      command.Parameters.AddWithValue("@NumSeats", numSeats);
            command.Parameters.AddWithValue("@MaxSeats", maxSeats);

            DBConnect DB = new DBConnect();
            DB.DoUpdateUsingCmdObj(command);
        }

    }
}
