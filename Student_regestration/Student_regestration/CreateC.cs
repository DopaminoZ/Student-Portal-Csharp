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
    public partial class CreateC : Form
    {
        public CreateC()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
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
            MessageBox.Show("Added course " + code.Text);
            con.Close();
        }
    }
}
