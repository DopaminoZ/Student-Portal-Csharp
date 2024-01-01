﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            List<Course> courses = Course.loadCourses();
            foreach (Course x in courses)
            {
                checkedListBox1.Items.Add(x.Code);
            }
        }
        string subjects = "";
        private void materialButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Users SET Subjects = @subs WHERE Id = @ID", con);
            SqlCommand courses = new SqlCommand("UPDATE Courses SET Students = @students WHERE Code = @Code", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regnum.Text));
            subjects = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    subjects += checkedListBox1.Items[i].ToString() + "-";
                    addToStudentList(checkedListBox1.Items[i].ToString());
                }
            }
            cmd.Parameters.AddWithValue("@subs", subjects);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered courses for student - " + regnum.Text);
            con.Close();
        }
        private void addToStudentList(string mada)
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();

            string studentList = "";

            SqlCommand read = new SqlCommand("SELECT Students FROM Courses WHERE Code = @Code", con);
            read.Parameters.AddWithValue("@Code", mada);

            using (SqlDataReader reader = read.ExecuteReader())
            {
                if (reader.Read())
                {
                    studentList = reader["Students"].ToString();
                }
            }
                studentList += "-" + int.Parse(regnum.Text);

                SqlCommand cmd = new SqlCommand("UPDATE Courses SET Students = @ID WHERE Code = @Code", con);
                cmd.Parameters.AddWithValue("@Code", mada);
                cmd.Parameters.AddWithValue("@ID", studentList);
                cmd.ExecuteNonQuery();
            

            con.Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            AdvisorPanel AP = new AdvisorPanel();
            AP.Show();
            this.Hide();
        }

       
    }
}
