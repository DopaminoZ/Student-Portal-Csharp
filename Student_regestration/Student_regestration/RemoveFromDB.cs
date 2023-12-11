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
    public partial class RemoveFromDB : Form
    {
        private Button Yes;
        private Button No;
        private Label Confirm;
        public RemoveFromDB()
        {
            InitializeComponent();
            Yes = new Button();
            Yes.Text = "Yes";
            Yes.Location = new System.Drawing.Point(124, 357);
            Yes.Click += new EventHandler(Yes_Click);
            Controls.Add(Yes);

            No = new Button();
            No.Text = "No";
            No.Location = new System.Drawing.Point(270, 357);
            No.Click += new EventHandler(No_Click);
            Controls.Add(No);

            Confirm = new Label();
            Confirm.AutoSize = true;
            Confirm.Location = new Point(152, 309);
            Confirm.Size = new Size(174, 15);
            Confirm.TabIndex = 18;
            Confirm.Text = "Are you sure this is the student?";
            this.Controls.Add(Confirm);

            Yes.Visible = false;
            No.Visible = false;
            Confirm.Visible = false;
        }
        //Delete
        private void Yes_Click(object sender, EventArgs e)
        {
            Yes.Visible = false;
            No.Visible = false;
            Confirm.Visible = false;
            deletename.Text = "Student Name - ";
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Users where Id = @ID ", con);
            SqlCommand marks = new SqlCommand("Delete marks where Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regdel.Text));
            cmd.ExecuteNonQuery();
            marks.Parameters.AddWithValue("@ID", int.Parse(regdel.Text));
            marks.ExecuteNonQuery();
            con.Close();
            regdel.Text = "";
            regdel.ReadOnly = false;
            MessageBox.Show("Done!");
        }
        private void No_Click(object sender, EventArgs e)
        {
            Yes.Visible = false;
            No.Visible = false;
            Confirm.Visible = false;
            regdel.ReadOnly = false;
            deletename.Text = "Student Name - ";
            regdel.Text = "";
            MessageBox.Show("Reverted first request!");
        }



        private void Del_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Users WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regdel.Text));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string studentName = reader["Name"].ToString();
                    deletename.Text = String.Format("Student Name - {0}", studentName);
                    Yes.Visible = true;
                    No.Visible = true;
                    Confirm.Visible = true;
                    regdel.ReadOnly = true;
                }
                else
                {
                    deletename.Text = "Student not found!, try another Reg Num...";
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Show();
            this.Hide();
        }
    }
}
