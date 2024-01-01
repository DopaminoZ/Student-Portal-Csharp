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
using System.Xml.Linq;

namespace Student_regestration
{
    public partial class AddProg : Form
    {
        public AddProg()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into postprog ( Programme ) values (@Programme)", con);
            cmd.Parameters.AddWithValue("@Programme", textBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added a programme!");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            AdvisorPanel advisorPanel = new AdvisorPanel();
            advisorPanel.Show();
            this.Hide();
        }
    }
}
