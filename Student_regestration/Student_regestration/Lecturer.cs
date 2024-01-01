using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_regestration
{
    public partial class Lecturer : Form
    {
        LecturerClass lec;
        public Lecturer(LecturerClass a)
        {
            InitializeComponent();
            lec = a;
            if (lec.Admin == "true")
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Courses WHERE Lecturers = @ID", con);
            cmd.Parameters.AddWithValue("@ID", lec.ID);
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
                students = Lecturer.getStudents(allStudents);
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
        public string calculateGrade()
        {
            double[] d = new double[4];
            try
            {
                if (string.IsNullOrWhiteSpace(text7.Text) || string.IsNullOrWhiteSpace(text12.Text) || string.IsNullOrWhiteSpace(textwork.Text))
                {
                    if (label5.Text != "U")
                        d[0] = double.Parse(label5.Text);
                    else
                        d[0] = 0;
                    if (label6.Text != "U")
                        d[1] = double.Parse(label6.Text);
                    else
                        d[1] = 0;
                    if (label7.Text != "U")
                        d[2] = double.Parse(label7.Text);
                    else
                        d[2] = 0;
                }
                else
                {
                    if (text7.Text != "U")
                        d[0] = double.Parse(text7.Text);
                    else
                        d[0] = 0;
                    if (text12.Text != "U")
                        d[1] = double.Parse(text12.Text);
                    else
                        d[1] = 0;
                    if (textwork.Text != "U")
                        d[2] = double.Parse(textwork.Text);
                    else
                        d[2] = 0;
                }
                if (textfinal.Text != "U")
                    d[3] = double.Parse(textfinal.Text);
                else
                    d[3] = 0;
            }
            catch (Exception ex)
            {
                errormes.Text = ex.Message;
            }


            double score = d[0] + d[1] + d[2] + d[3];
            switch (score)
            {
                case double s when (s >= 97 && s <= 100):
                    return "A+";
                case double s when (s >= 93 && s < 97):
                    return "A";
                case double s when (s >= 89 && s < 93):
                    return "A-";
                case double s when (s >= 86 && s < 89):
                    return "B+";
                case double s when (s >= 83 && s < 86):
                    return "B";
                case double s when (s >= 80 && s < 83):
                    return "B-";
                case double s when (s >= 77 && s < 80):
                    return "C+";
                case double s when (s >= 73 && s < 77):
                    return "C";
                case double s when (s >= 69 && s < 73):
                    return "C-";
                case double s when (s >= 60 && s < 63):
                    return "D";
                case double s when (s < 60 && s >= 0):
                    return "F";
                default:
                    return "Invalid score";

            }
        }
        string[] x = new string[6];
        public void displayGrades()
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
                    x[5] = calculateGrade();
                    grade.Text = "Final Grade - " + calculateGrade();
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayGrades();
        }

        private void textfinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            displayGrades();
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
                    double.Parse(textwork.Text) > 10 ||
                    double.Parse(textfinal.Text) > 40)
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

        private void materialButton2_Click(object sender, EventArgs e)
        {
            displayGrades();
            UpdateGrades();
            displayGrades();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
