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

namespace Student_regestration
{
    public partial class Lecturer : Form
    {
        public Lecturer(int Term, string Subject)
        {
            InitializeComponent();
            LecturerTerm = Term;
            LecturerSubject = Subject;
            ShowStudentList();
        }
        private int LecturerTerm;
        private string LecturerSubject;
        public void ShowStudentList()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aliba\\Desktop\\Student_regestration\\Student-Portal-C-\\Student_regestration\\Student_regestration\\Database1.mdf;Integrated Security=True");
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
            if (string.IsNullOrWhiteSpace(text7.Text) || string.IsNullOrWhiteSpace(text12.Text) || string.IsNullOrWhiteSpace(textwork.Text))
            {
                if (text7.PlaceholderText != "U")
                    d[0] = double.Parse(text7.PlaceholderText);
                else
                    d[0] = 0;
                if (text12.PlaceholderText != "U")
                    d[1] = double.Parse(text12.PlaceholderText);
                else
                    d[1] = 0;
                if (textwork.PlaceholderText != "U")
                    d[2] = double.Parse(textwork.PlaceholderText);
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

            double score = d[0] + d[1] + d[2] + d[3];
            switch (score)
            {
                case double s when (s >= 90 && s <= 100):
                    return "A";

                case double s when (s >= 80 && s < 90):
                    return "B";

                case double s when (s >= 70 && s < 80):
                    return "C";

                case double s when (s >= 60 && s < 70):
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
            string sub = LecturerSubject;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aliba\\Desktop\\Student_regestration\\Student-Portal-C-\\Student_regestration\\Student_regestration\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM marks WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", comboBox1.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    ReturnMarks(ref x, reader[LecturerSubject].ToString());
                    text7.PlaceholderText = x[2];
                    text12.PlaceholderText = x[3];
                    textwork.PlaceholderText = x[4];
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
            x[2] = text7.Text;
            x[3] = text12.Text;
            x[4] = textwork.Text;
            string newmark = x[0] + " " + x[1] + " " + x[2] + " " + x[3] + " " + x[4] + " " + x[5];
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aliba\\Desktop\\Student_regestration\\Student-Portal-C-\\Student_regestration\\Student_regestration\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE marks SET {LecturerSubject} = @mark1 WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(comboBox1.Text));
            cmd.Parameters.AddWithValue("@mark1", newmark);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated the marks for user " + comboBox1.Text);
        }
        //Dops 8yar el 8oz2 bta3 code w name fel newmark, DONZO
        //add column fel users taba3 subject el dr DONZO
        //Maybe replace display marks in labels not placeholder, dunno yet WILLDO
        //Add GPA TO STUDENT REPORT
        private void materialButton2_Click(object sender, EventArgs e)
        {
            UpdateGrades();
        }
    }
}
