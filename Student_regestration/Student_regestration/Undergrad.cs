using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student_regestration
{
    public class Undergrad : Student
    {
        protected int Term;
        public Undergrad(int ID, string Password, string Name, string Gender, DateTime DoB, int Term) : base(ID, Password, Name, Gender, DoB)
        { 
            this.Term = Term;
        }
        public void UpdateValues(Grade_Report GR)
        {
            string[] markz = new string[6] { "CC319", "CC317", "NE466", "EC339", "EC320", "BA323" };
            string[] parts = new string[6];
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM marks WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    GR.title.Text = "Grade Report for " + ID;
                    Grade_Report.ReturnMarks(ref parts, reader[markz[0]].ToString());
                    GR.code1.Text = parts[0];
                    GR.name1.Text = parts[1];
                    GR.mark71.Text = parts[2];
                    GR.mark121.Text = parts[3];
                    GR.mark1.Text = parts[4];
                    GR.markG1.Text = parts[5];
                    Grade_Report.ReturnMarks(ref parts, reader[markz[1]].ToString());
                    GR.code2.Text = parts[0];
                    GR.name2.Text = parts[1];
                    GR.mark72.Text = parts[2];
                    GR.mark122.Text = parts[3];
                    GR.mark2.Text = parts[4];
                    GR.markG2.Text = parts[5];
                    Grade_Report.ReturnMarks(ref parts, reader[markz[2]].ToString());
                    GR.code3.Text = parts[0];
                    GR.name3.Text = parts[1];
                    GR.mark73.Text = parts[2];
                    GR.mark123.Text = parts[3];
                    GR.mark3.Text = parts[4];
                    GR.markG3.Text = parts[5];
                    Grade_Report.ReturnMarks(ref parts, reader[markz[3]].ToString());
                    GR.code4.Text = parts[0];
                    GR.name4.Text = parts[1];
                    GR.mark74.Text = parts[2];
                    GR.mark124.Text = parts[3];
                    GR.mark4.Text = parts[4];
                    GR.markG4.Text = parts[5];
                    Grade_Report.ReturnMarks(ref parts, reader[markz[4]].ToString());
                    GR.code5.Text = parts[0];
                    GR.name5.Text = parts[1];
                    GR.mark75.Text = parts[2];
                    GR.mark125.Text = parts[3];
                    GR.mark5.Text = parts[4];
                    GR.markG5.Text = parts[5];
                    Grade_Report.ReturnMarks(ref parts, reader[markz[5]].ToString());
                    GR.code6.Text = parts[0];
                    GR.name6.Text = parts[1];
                    GR.mark76.Text = parts[2];
                    GR.mark126.Text = parts[3];
                    GR.mark6.Text = parts[4];
                    GR.markG6.Text = parts[5];
                    GR.GPA.Text = reader["GPA"].ToString();
                }
            }
        }
    }
}
