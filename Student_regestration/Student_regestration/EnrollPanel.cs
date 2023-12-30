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
    public partial class EnrollPanel : Form
    {
        public EnrollPanel()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name.Text) ||
                    string.IsNullOrWhiteSpace(email.Text) ||
                    string.IsNullOrWhiteSpace(comboBox1.Text) ||
                    string.IsNullOrWhiteSpace(comboBox2.Text)
                    || string.IsNullOrWhiteSpace(email.Text)
                    || !malerb.Checked && !femalerb.Checked)
                {

                    errormes.Visible = true;
                    errormes.Text = "Please fill in all required fields.";
                }
                else
                {
                    SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into enrollments (Name,DoB,PreferredMajor,StartDate,Email,Gender) values (@Name,@DoB,@Major,@SD,@Email,@Gender)", con);
                    cmd.Parameters.AddWithValue("@Name", name.Text);
                    cmd.Parameters.AddWithValue("@DoB", dateob.Value);
                    cmd.Parameters.AddWithValue("@Major", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@SD", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    if (malerb.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Gender", "Male");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Gender", "Female");

                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                    errormes.Visible = false;
                    MessageBox.Show("Done! Please wait for an email from our adminstrators!");
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                errormes.Visible = true;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LoginPanel LP = new LoginPanel();
            LP.Show();
            this.Hide();
        }
    }
}
