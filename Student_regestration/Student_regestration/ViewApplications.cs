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
    public partial class ViewApplications : Form
    {
        public ViewApplications()
        {
            InitializeComponent();
            BindDataGridView();
        }


        private void BindDataGridView()
        {
            using (SqlConnection con = new SqlConnection(AddtoDB.databaseConnection))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM postprog", con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
