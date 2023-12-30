using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_regestration
{
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
                con.Open();
                string columnName = code.Text;
                SqlCommand cmd = new SqlCommand("insert into Courses ( Code,Name,Credit) values (@Code,@Name,@Credit)", con);
                SqlCommand command = new SqlCommand($"ALTER TABLE marks ADD {columnName} VARCHAR(50)", con);
                cmd.Parameters.AddWithValue("@Code", code.Text);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Credit", int.Parse(credit.Text));
                cmd.ExecuteNonQuery();
                command.ExecuteNonQuery();
                con.Close();
                errormes.Visible = false;
                MessageBox.Show("Added course " + code.Text);
            }
            catch (Exception ex)
            {
                errormes.Visible = true;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            AdvisorPanel AP = new AdvisorPanel();
            AP.Show();
            this.Hide();
        }
    }
}
