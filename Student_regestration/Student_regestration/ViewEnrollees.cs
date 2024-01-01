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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Student_regestration
{
    public partial class ViewEnrollees : Form
    {
        int no_of_enrollees;
        public ViewEnrollees()
        {
            InitializeComponent();
            CountEnrollees();
            number.Text = "Number of Enrollees: " + no_of_enrollees.ToString();
            BindDataGridView();
        }
        public void CountEnrollees()
        {
            SqlConnection con = new SqlConnection(AddtoDB.databaseConnection);
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS row_count FROM enrollments;", con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        no_of_enrollees = Convert.ToInt32(reader["row_count"]);

                    }
                }
            }

        }
        private void BindDataGridView()
        {
            using (SqlConnection con = new SqlConnection(AddtoDB.databaseConnection))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM enrollments", con))
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

        private void materialButton2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int recordId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value);

                using (SqlConnection connection = new SqlConnection(AddtoDB.databaseConnection))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM enrollments WHERE Id = @RecordId", connection))
                    {
                        command.Parameters.AddWithValue("@RecordId", recordId);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }


                dataGridView1.Rows.RemoveAt(selectedRowIndex);
                no_of_enrollees--;
                number.Text = "Number of Enrollees: " + no_of_enrollees.ToString();
            }


        }

        private void RemoveAndRefresh(DataGridView dataGridView)
        {


        }

        private void RemoveRowFromDatabase(int recordId)
        {


        }
    }
}
