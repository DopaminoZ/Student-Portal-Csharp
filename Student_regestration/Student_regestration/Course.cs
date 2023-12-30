using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    public class Course
    {
        private string name;
        private string code;
        private int creditHours;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Code
        {
            set { code = value; }
            get { return code; }
        }
        public int CreditHours
        {
            set
            {
                if (value > 0)
                    creditHours = value;
            }
            get { return creditHours; }

        }
        public Course(string Name, string Code, int CreditHours)
        {
            this.Name = Name;
            this.Code = Code;
            this.CreditHours = CreditHours;

        }
        public static List<Course> loadCourses()
        {
            List<Course> courses = new List<Course>();
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Courses", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nameez = reader["Name"].ToString();
                    string codeez = reader["Code"].ToString();
                    int creditz = int.Parse(reader["Credit"].ToString());
                    Course Temp = new Course(nameez, codeez, creditz);
                    courses.Add(Temp);
                }
            }
            con.Close();
            return courses;

        }
    }
}
