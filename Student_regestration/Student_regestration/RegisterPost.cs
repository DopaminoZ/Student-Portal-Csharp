using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_regestration
{
    public partial class RegisterPost : Form
    {
        Postgrad x;
        public RegisterPost(Postgrad signedin)
        {
            InitializeComponent();
            x = signedin;
            loadProgrammes();
            typebox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE postprog SET Applicants = @subs WHERE Programme = @ID", con);
            cmd.Parameters.AddWithValue("@ID", typebox.Text);
            string applicants = "";
            SqlCommand read = new SqlCommand("SELECT * from postprog Where Programme = @ID", con);
            read.Parameters.AddWithValue("@ID", typebox.Text);
            using (SqlDataReader reader = read.ExecuteReader())
            {
                if (reader.Read())
                {
                    applicants = reader["Applicants"].ToString();
                }
                else
                {
                    applicants = "";
                }
            }
                applicants += "-" + x.ID;
                cmd.Parameters.AddWithValue("@subs", applicants);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done! Please wait for us to contact you to confirm your application " + x.Name);
                con.Close();
            

        }
        private void loadProgrammes()
        {
           
                SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM postprog", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string prog = reader["Programme"].ToString();
                        typebox.Items.Add(prog);
                    }
                }
            
        }
    }
}
