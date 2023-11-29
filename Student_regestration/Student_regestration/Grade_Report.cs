using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_regestration
{
    public partial class Grade_Report : Form
    {
        public Grade_Report(int RegId)
        {
            InitializeComponent();
            RegIdz = RegId;
            UpdateValues();
        }
        private static int RegIdz;
        private static void ReturnMarks(ref string[] x, string all)
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
            mark7 = all.Substring(j + 1, i-j-1);
            x[2] = mark7;
            j = i + 1;
            while (all[j] != ' ' && j < all.Length)
            {
                j++;
            }
            mark12 = all.Substring(i+1, j-i-1);
            x[3] = mark12;
            i= j + 1;
            while (all[i] != ' ' && i < all.Length)
            {
                i++;
            }
            markcourse = all.Substring(j + 1, i - j - 1);
            x[4] = markcourse;
            markGrade = all.Substring(i + 1);
            x[5] = markGrade;
        }
        public void UpdateValues()
        {
            string[] parts = new string[6];
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Ali\\repo\\Student-Portal-Csharp\\Student_regestration\\Student_regestration\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM marks WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", RegIdz);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    title.Text = "Grade Report for " + RegIdz;
                    ReturnMarks(ref parts, reader["mark1"].ToString());
                    code1.Text = parts[0];
                    name1.Text = parts[1];
                    mark71.Text = parts[2];
                    mark121.Text = parts[3];
                    mark1.Text = parts[4];
                    markG1.Text = parts[5];
                    ReturnMarks(ref parts, reader["mark2"].ToString());
                    code2.Text = parts[0];
                    name2.Text = parts[1];
                    mark72.Text = parts[2];
                    mark122.Text = parts[3];
                    mark2.Text = parts[4];
                    markG2.Text = parts[5];
                    ReturnMarks(ref parts, reader["mark3"].ToString());
                    code3.Text = parts[0];
                    name3.Text = parts[1];
                    mark73.Text = parts[2];
                    mark123.Text = parts[3];
                    mark3.Text = parts[4];
                    markG3.Text = parts[5];
                    ReturnMarks(ref parts, reader["mark4"].ToString());
                    code4.Text = parts[0];
                    name4.Text = parts[1];
                    mark74.Text = parts[2];
                    mark124.Text = parts[3];
                    mark4.Text = parts[4];
                    markG4.Text = parts[5];
                    ReturnMarks(ref parts, reader["mark5"].ToString());
                    code5.Text = parts[0];
                    name5.Text = parts[1];
                    mark75.Text = parts[2];
                    mark125.Text = parts[3];
                    mark5.Text = parts[4];
                    markG5.Text = parts[5];
                    ReturnMarks(ref parts, reader["mark6"].ToString());
                    code6.Text = parts[0];
                    name6.Text = parts[1];
                    mark76.Text = parts[2];
                    mark126.Text = parts[3];
                    mark6.Text = parts[4];
                    markG6.Text = parts[5];

                }
            }
        }

    }
}
