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
        TeachingAssistant xz = new TeachingAssistant();
        public TA(TeachingAssistant a)
        {
            xz = a;
            InitializeComponent();
            if (a.Admin == "true")
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
            UpdCourseList();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void UpdCourseList()
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Courses WHERE TAs = @ID", con);
            cmd.Parameters.AddWithValue("@ID", xz.ID);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string Code = reader["Code"].ToString();
                    comboBox2.Items.Add(Code);
                }

            }
        }
        public void ShowStudentList()
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            string allStudents = "";
            string[] students;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Courses WHERE Code = @Code", con);
            cmd.Parameters.AddWithValue("@Code", comboBox2.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    allStudents = reader["Students"].ToString();
                }
            }

            if (allStudents.Length > 1)
            {
                students = TA.getStudents(allStudents);
                foreach (string student in students)
                {
                    if (!comboBox1.Items.Contains(student))
                    {
                        comboBox1.Items.Add(student);
                    }
                }
            }
            

        }
        static string[] getStudents(string input)
        {
            input = input.Substring(1);
            string[] result = input.Split('-');
            return result;
        }
        public void displayGrades()
        {
            try
            {
                SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM marks WHERE Id = @ID", con);
                cmd.Parameters.AddWithValue("@ID", comboBox1.Text);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ReturnMarks(ref x, reader[comboBox2.Text].ToString());
                        label5.Text = x[2];
                        label6.Text = x[3];
                        label7.Text = x[4];

                    }

                }
            }
            catch (Exception ex)
            {
                errormes.Text = ex.Message;
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
            try
            {
                if (string.IsNullOrWhiteSpace(text7.Text) ||
                    string.IsNullOrWhiteSpace(text12.Text) ||
                    string.IsNullOrWhiteSpace(textwork.Text))
                {
                    errormes.Text = "Please fill all fields.";
                    errormes.Visible = true;
                }
                else if (double.Parse(text7.Text) > 30
                    || double.Parse(text12.Text) > 20 ||
                    double.Parse(textwork.Text) > 10)
                {
                    errormes.Text = "Some of the inputs exceed maximum mark...";
                    errormes.Visible = true;
                }
                else
                {
                    x[2] = text7.Text;
                    x[3] = text12.Text;
                    x[4] = textwork.Text;
                    string newmark = x[0] + " " + x[1] + " " + x[2] + " " + x[3] + " " + x[4] + " " + x[5];
                    SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"UPDATE marks SET {comboBox2.Text} = @mark WHERE Id = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(comboBox1.Text));
                    cmd.Parameters.AddWithValue("@mark", newmark);
                    cmd.ExecuteNonQuery();
                    errormes.Visible = false;
                    MessageBox.Show("Updated the marks for user " + comboBox1.Text);
                }
            }
            catch (Exception ex)
            {
                errormes.Text = ex.Message;
                errormes.Visible = true;
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            ShowStudentList();
            displayGrades();
        }
    }
}
