using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Student_regestration
{
    public class Undergrad : Student
    {
        protected int Term { get; set; }
        protected List<Course> Courses { get; set; }
        protected string Subjects;
        public Undergrad() : base()
        {
            Term = 0;
            Courses = new List<Course>();
        }
        public Undergrad(int ID, string Password, string Name, string Gender, DateTime DoB, int Term, List<Course> Courses) : base(ID, Password, Name, Gender, DoB)
        { 
            this.Term = Term;
            this.Courses = Courses;
        }
        private void ReturnMarks(ref string[] x, string all)
        {
            int i = 0;
            int j = 0;
            string code, name, mark7, mark12, markcourse, markGrade;
            while (all[i] != ' ' && i < all.Length)
            {
                i++;
            }
            j = i + 1;
            while (all[j] != ' ' && j < all.Length)
            {
                j++;
            }
            code = all.Substring(0, i);
            x[0] = code;
            name = all.Substring(i + 1, j - i - 1);
            x[1] = name;
            i = j + 1;
            while (all[i] != ' ' && i < all.Length)
            {
                i++;
            }
            mark7 = all.Substring(j + 1, i - j - 1);
            x[2] = mark7;
            j = i + 1;
            while (all[j] != ' ' && j < all.Length)
            {
                j++;
            }
            mark12 = all.Substring(i + 1, j - i - 1);
            x[3] = mark12;
            i = j + 1;
            while (all[i] != ' ' && i < all.Length)
            {
                i++;
            }
            markcourse = all.Substring(j + 1, i - j - 1);
            x[4] = markcourse;
            markGrade = all.Substring(i + 1);
            x[5] = markGrade;
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
                    Subjects = reader["Subjects"].ToString();
                }
            }
            
        }
        static string[] FetchRegCourses(string input)
        {
            string[] coursesz = input.Split('-');
            return coursesz;
        }

        public void FetchMarks(Grade_Report GR)
        {
            string[] markz = Undergrad.FetchRegCourses(Subjects);
            string[] parts = new string[6];
            int number_of_course=markz.Length-1;
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM marks WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    GR.title.Text = "Grade Report for " + ID;
                    switch (number_of_course) {
                        case 0:
                            GR.GPA.Text = reader["GPA"].ToString(); 
                            break;
                        case 1:
                            GR.panel1.Visible = true;
                            ReturnMarks(ref parts, reader[markz[0]].ToString());
                            GR.code1.Text = parts[0];
                            GR.name1.Text = parts[1];
                            GR.mark71.Text = parts[2];
                            GR.mark121.Text = parts[3];
                            GR.mark1.Text = parts[4];
                            GR.markG1.Text = parts[5];
                            GR.GPA.Text = reader["GPA"].ToString();
                            break;
                        case 2:
                            GR.panel1.Visible = true;
                            GR.panel2.Visible = true;
                            ReturnMarks(ref parts, reader[markz[0]].ToString());
                            GR.code1.Text = parts[0];
                            GR.name1.Text = parts[1];
                            GR.mark71.Text = parts[2];
                            GR.mark121.Text = parts[3];
                            GR.mark1.Text = parts[4];
                            GR.markG1.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[1]].ToString());
                            GR.code2.Text = parts[0];
                            GR.name2.Text = parts[1];
                            GR.mark72.Text = parts[2];
                            GR.mark122.Text = parts[3];
                            GR.mark2.Text = parts[4];
                            GR.markG2.Text = parts[5];
                            GR.GPA.Text = reader["GPA"].ToString();
                            break;
                        case 3:
                            GR.panel1.Visible = true;
                            GR.panel2.Visible = true;
                            GR.panel3.Visible = true;
                            ReturnMarks(ref parts, reader[markz[0]].ToString());
                            GR.code1.Text = parts[0];
                            GR.name1.Text = parts[1];
                            GR.mark71.Text = parts[2];
                            GR.mark121.Text = parts[3];
                            GR.mark1.Text = parts[4];
                            GR.markG1.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[1]].ToString());
                            GR.code2.Text = parts[0];
                            GR.name2.Text = parts[1];
                            GR.mark72.Text = parts[2];
                            GR.mark122.Text = parts[3];
                            GR.mark2.Text = parts[4];
                            GR.markG2.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[2]].ToString());
                            GR.code3.Text = parts[0];
                            GR.name3.Text = parts[1];
                            GR.mark73.Text = parts[2];
                            GR.mark123.Text = parts[3];
                            GR.mark3.Text = parts[4];
                            GR.markG3.Text = parts[5];
                            GR.GPA.Text = reader["GPA"].ToString();
                            break;
                        case 4:
                            GR.panel1.Visible = true;
                            GR.panel2.Visible = true;
                            GR.panel3.Visible = true;
                            GR.panel4.Visible = true;
                            ReturnMarks(ref parts, reader[markz[0]].ToString());
                            GR.code1.Text = parts[0];
                            GR.name1.Text = parts[1];
                            GR.mark71.Text = parts[2];
                            GR.mark121.Text = parts[3];
                            GR.mark1.Text = parts[4];
                            GR.markG1.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[1]].ToString());
                            GR.code2.Text = parts[0];
                            GR.name2.Text = parts[1];
                            GR.mark72.Text = parts[2];
                            GR.mark122.Text = parts[3];
                            GR.mark2.Text = parts[4];
                            GR.markG2.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[2]].ToString());
                            GR.code3.Text = parts[0];
                            GR.name3.Text = parts[1];
                            GR.mark73.Text = parts[2];
                            GR.mark123.Text = parts[3];
                            GR.mark3.Text = parts[4];
                            GR.markG3.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[3]].ToString());
                            GR.code4.Text = parts[0];
                            GR.name4.Text = parts[1];
                            GR.mark74.Text = parts[2];
                            GR.mark124.Text = parts[3];
                            GR.mark4.Text = parts[4];
                            GR.markG4.Text = parts[5];
                            GR.GPA.Text = reader["GPA"].ToString();
                            break;
                        case 5:
                            GR.panel1.Visible = true;
                            GR.panel2.Visible = true;
                            GR.panel3.Visible = true;
                            GR.panel4.Visible = true;
                            GR.panel5.Visible = true;
                            ReturnMarks(ref parts, reader[markz[0]].ToString());
                            GR.code1.Text = parts[0];
                            GR.name1.Text = parts[1];
                            GR.mark71.Text = parts[2];
                            GR.mark121.Text = parts[3];
                            GR.mark1.Text = parts[4];
                            GR.markG1.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[1]].ToString());
                            GR.code2.Text = parts[0];
                            GR.name2.Text = parts[1];
                            GR.mark72.Text = parts[2];
                            GR.mark122.Text = parts[3];
                            GR.mark2.Text = parts[4];
                            GR.markG2.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[2]].ToString());
                            GR.code3.Text = parts[0];
                            GR.name3.Text = parts[1];
                            GR.mark73.Text = parts[2];
                            GR.mark123.Text = parts[3];
                            GR.mark3.Text = parts[4];
                            GR.markG3.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[3]].ToString());
                            GR.code4.Text = parts[0];
                            GR.name4.Text = parts[1];
                            GR.mark74.Text = parts[2];
                            GR.mark124.Text = parts[3];
                            GR.mark4.Text = parts[4];
                            GR.markG4.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[4]].ToString());
                            GR.code5.Text = parts[0];
                            GR.name5.Text = parts[1];
                            GR.mark75.Text = parts[2];
                            GR.mark125.Text = parts[3];
                            GR.mark5.Text = parts[4];
                            GR.markG5.Text = parts[5];
                            GR.GPA.Text = reader["GPA"].ToString();
                            break;
                        case 6:
                            GR.panel1.Visible = true;
                            GR.panel2.Visible = true;
                            GR.panel3.Visible = true;
                            GR.panel4.Visible = true;
                            GR.panel5.Visible = true;
                            GR.panel6.Visible = true;
                            ReturnMarks(ref parts, reader[markz[0]].ToString());
                            GR.code1.Text = parts[0];
                            GR.name1.Text = parts[1];
                            GR.mark71.Text = parts[2];
                            GR.mark121.Text = parts[3];
                            GR.mark1.Text = parts[4];
                            GR.markG1.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[1]].ToString());
                            GR.code2.Text = parts[0];
                            GR.name2.Text = parts[1];
                            GR.mark72.Text = parts[2];
                            GR.mark122.Text = parts[3];
                            GR.mark2.Text = parts[4];
                            GR.markG2.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[2]].ToString());
                            GR.code3.Text = parts[0];
                            GR.name3.Text = parts[1];
                            GR.mark73.Text = parts[2];
                            GR.mark123.Text = parts[3];
                            GR.mark3.Text = parts[4];
                            GR.markG3.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[3]].ToString());
                            GR.code4.Text = parts[0];
                            GR.name4.Text = parts[1];
                            GR.mark74.Text = parts[2];
                            GR.mark124.Text = parts[3];
                            GR.mark4.Text = parts[4];
                            GR.markG4.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[4]].ToString());
                            GR.code5.Text = parts[0];
                            GR.name5.Text = parts[1];
                            GR.mark75.Text = parts[2];
                            GR.mark125.Text = parts[3];
                            GR.mark5.Text = parts[4];
                            GR.markG5.Text = parts[5];
                            ReturnMarks(ref parts, reader[markz[5]].ToString());
                            GR.code6.Text = parts[0];
                            GR.name6.Text = parts[1];
                            GR.mark76.Text = parts[2];
                            GR.mark126.Text = parts[3];
                            GR.mark6.Text = parts[4];
                            GR.markG6.Text = parts[5];
                            GR.GPA.Text = reader["GPA"].ToString();
                            break;
                    }
                }
            }
            con.Close();
        }
    }
}
