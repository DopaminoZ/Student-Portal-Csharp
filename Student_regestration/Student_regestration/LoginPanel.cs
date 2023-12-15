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
                    int Id = int.Parse(reader["Id"].ToString());
                    string Pass = reader["Password"].ToString();
                    if (reader["Type"].ToString() == "Undergrad")
                    {
                        Undergrad SignedIn = new Undergrad();
                        SignedIn.FetchUserData(Id, Pass);
                        Grade_Report GR = new Grade_Report(SignedIn);
                        GR.Show();
                    }
                    if (reader["Type"].ToString() == "Lecturer")
                    {
                        LecturerClass a = new LecturerClass();
                        a.FetchUserData(Id, Pass);
                        Lecturer LP = new Lecturer(a);
                        LP.Show();
                        
                    }
                    if (reader["Type"].ToString() == "Teaching Assistant")
                    {
                        TeachingAssistant a = new TeachingAssistant();
                        a.FetchUserData(Id, Pass);
                        TA LP = new TA(a);
                        LP.Show();
                        
                    }
                    this.Hide();
                }
                else
                {
                    label3.Text = "Invalid credentials, try again or talk to your supervisor...";
                }
            }
            con.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            EnrollPanel EP = new EnrollPanel();
            EP.Show();
            this.Hide(); 
        }
    }
}
