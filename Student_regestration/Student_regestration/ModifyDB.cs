using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_regestration
{
    public partial class ModifyDB : Form
    {
        public ModifyDB()
        {
            InitializeComponent();
            materialButton3.Visible = false;
            namemod.ReadOnly = true;
            datemod.Enabled = false;
            termmod.ReadOnly = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Show();
            this.Hide();
        }

        //Modify
        string newterm, newname;
        string Regid;
        DateTime newdate;
        private void materialButton3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Users SET Name = @Name, DoB = @Date, Term = @Term WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regmod.Text));
            cmd.Parameters.AddWithValue("@Name", newname);
            cmd.Parameters.AddWithValue("@Term", int.Parse(newterm));
            cmd.Parameters.AddWithValue("@Date", newdate);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Edited the data for user " + Regid);
            materialButton4_Click(sender, e);
            regmod.ReadOnly = false;
            namemod.ReadOnly = true;
            datemod.Enabled = false;
            termmod.ReadOnly = true;
            materialButton4.Visible = true;
            materialButton3.Visible = false;

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regmod.Text));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string studentName = reader["Name"].ToString();
                    string date = reader["DoB"].ToString();
                    date = date.Substring(0, 10);
                    if (date[8] == ' ' && date[9] != ' ')
                    {
                        date = date.Substring(0, 9);
                    }
                    Regid = regmod.Text;
                    displaymod.Text = String.Format("Student Name - {0}", studentName);
                    namedisplay.Text = studentName;
                    datedisplay.Text = date;
                    termdisplay.Text = reader["Term"].ToString();
                    regmod.ReadOnly = true;
                    namemod.ReadOnly = false;
                    datemod.Enabled = true;
                    termmod.ReadOnly = false;
                    materialButton4.Visible = false;
                    materialButton3.Visible = true;


                }
                else
                {
                    displaymod.Text = "Student not found!, try another Reg Num...";

                }
            }
        }

        private void termmod_TextChanged_1(object sender, EventArgs e)
        {
            newterm = termmod.Text;
        }

        private void datemod_ValueChanged(object sender, EventArgs e)
        {
            newdate = datemod.Value;
        }

        private void namemod_TextChanged(object sender, EventArgs e)
        {
            newname = namemod.Text;
        }
    }
}
