using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    public class TeachingAssistant : Staff
    {
        protected List<Course> Courses {  get; set; }
        public TeachingAssistant(int ID, string Password, string Name, string Gender, DateTime DoB, double salary, string Admin, int Term, List<Course> Courses) : base(ID, Password, Name, Gender, DoB, salary, Admin, Term)
        {
            this.Courses = Courses;
        }
        public TeachingAssistant() : base()
        {
            this.Courses = null;
        }
        public void FetchUserData(int Id, string pass)
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Id = @ID AND Password = @pass", con);
            cmd.Parameters.AddWithValue("@ID", Id);
            cmd.Parameters.AddWithValue("@pass", pass);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    this.ID = Id;
                    this.Password = pass;
                    this.Name = reader["Name"].ToString();
                    this.Gender = reader["Gender"].ToString();
                    this.DoB = reader.GetDateTime(reader.GetOrdinal("DoB"));
                    this.Term = int.Parse(reader["Term"].ToString());
                    this.Admin = reader["Admin"].ToString();
                }
            }

        }
    }
}
