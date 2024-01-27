using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_regestration
{
    public class Postgrad : Student
    {
        protected int YearofGrad { get; set; }
        public Postgrad(int ID, string Password, string Name, string Gender, DateTime DoB, int YearofGrad) : base(ID, Password, Name, Gender, DoB)
        {
            this.YearofGrad = YearofGrad;
        }
        public Postgrad() 
        {
            YearofGrad = 0;
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
                   
                }
            }

        }
    }
}
