using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_regestration
{
    public partial class TA : Form
    {
        public TA(int Term, string Subject, bool Admin)
        {
            InitializeComponent();
            LecturerTerm = Term;
            LecturerSubject = Subject;
            if (Admin)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
            ShowStudentList();
        }
        private int LecturerTerm;
        private string LecturerSubject;

        public void ShowStudentList()
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Term = @ID AND Type != 'Lecturer' AND Type != 'Teaching Assistant'", con);
            cmd.Parameters.AddWithValue("@ID", LecturerTerm);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string regnum = reader["Id"].ToString();
                    comboBox1.Items.Add(regnum);
                }

            }
        }
        public void displayGrades()
        {
            string sub = LecturerSubject;
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM marks WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", comboBox1.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    ReturnMarks(ref x, reader[LecturerSubject].ToString());
                    label5.Text = x[2];
                    label6.Text = x[3];
                    label7.Text = x[4];

                }

            }
        }
        string[] x = new string[6];
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
        public void UpdateGrades()
        {
            x[2] = text7.Text;
            x[3] = text12.Text;
            x[4] = textwork.Text;
            string newmark = x[0] + " " + x[1] + " " + x[2] + " " + x[3] + " " + x[4] + " " + x[5];
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE marks SET {LecturerSubject} = @mark WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(comboBox1.Text));
            cmd.Parameters.AddWithValue("@mark", newmark);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated the marks for user " + comboBox1.Text);
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayGrades();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            UpdateGrades();
            displayGrades();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Show();
        }
    }
}
