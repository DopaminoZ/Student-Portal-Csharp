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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CQ83DFV\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoginData WHERE Id = @ID AND Password = @pass", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(idbox.Text));
            cmd.Parameters.AddWithValue("@pass", passwordbox.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                 
                    label3.Text = "Login successful...";
                    if (reader["Admin"].ToString() == "true")
                    {
                       AddtoDB AP =  new AddtoDB();
                        AP.Show();
                    }
                    
                    this.Hide();
                    
                  

                }
                else
                {
                    label3.Text = "Invalid credentials, try again or talk to your supervisor...";
                }
            }
        }
    }
}
