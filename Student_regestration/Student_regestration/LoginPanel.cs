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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
            label3.Text = "";

        }
        private void loginButton_Click(object sender, EventArgs e)
        {

            AuthUser();
        }
        private void AuthUser()
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Id = @ID AND Password = @pass", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(idbox.Text));
            cmd.Parameters.AddWithValue("@pass", passwordbox.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int RegId = int.Parse(reader["Id"].ToString());

                    label3.Text = "Login successful...";
                    if (reader["Admin"].ToString() == "true")
                    {
                        AddtoDB AP = new AddtoDB();
                        AP.Show();
                    }
                    if (reader["Type"].ToString() == "Student")
                    {
                        Grade_Report GR = new Grade_Report(RegId);
                        GR.Show();
                    }
                    if (reader["Type"].ToString() == "Lecturer")
                    {
                        int TermLec = int.Parse(reader["Term"].ToString());
                        string TermSub = reader["Subject"].ToString();
                        Lecturer LP = new Lecturer(TermLec, TermSub);
                        LP.Show();
                    }
                    if (reader["Type"].ToString() == "Teaching Assistant")
                    {
                        int TermLec = int.Parse(reader["Term"].ToString());
                        string TermSub = reader["Subject"].ToString();
                        TA LP = new TA(TermLec, TermSub);
                        LP.Show();
                    }

                    this.Hide();

                }
                else
                {
                    label3.Text = "Invalid credentials, try again or talk to your supervisor...";
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            EnrollPanel EP = new EnrollPanel();
            EP.Show();
            this.Hide(); 
        }
    }
}
