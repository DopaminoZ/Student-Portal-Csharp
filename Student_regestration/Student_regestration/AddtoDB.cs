using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Student_regestration
{
    public partial class AddtoDB : Form
    {


        public static string databaseConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Ali\\repo\\Student-Portal-Csharp\\Student_regestration\\Student_regestration\\Database1.mdf;Integrated Security=True";
        public AddtoDB()
        {
            InitializeComponent();
        }
        //Add
        private void materialButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users ( Id,Password,Name,Term,DoB,Gender,Type,Admin) values (@Id,@Pass,@Name,@Term,@DoB,@Gender,@Type,@Admin)", con);
            SqlCommand marks = new SqlCommand("insert into marks ( Id,CC319,CC317,NE466,EC320,EC339,BA323) values (@Id,@CC319,@CC317,@NE466,@EC320,@EC339,@BA323)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(reg.Text));
            cmd.Parameters.AddWithValue("@Pass", passbox.Text);
            cmd.Parameters.AddWithValue("@Name", name.Text);
            cmd.Parameters.AddWithValue("@DoB", dateob.Value);
            cmd.Parameters.AddWithValue("@Term", int.Parse(term.Text));
            if (malerb.Checked)
            {
                cmd.Parameters.AddWithValue("@Gender", "Male");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Gender", "Female");

            }
            cmd.Parameters.AddWithValue("@Type", typebox.Text);
            if (typebox.Text == "Undergrad" || typebox.Text == "Postgrad")
            {
                cmd.Parameters.AddWithValue("@Admin", "false");
            }
            else
            {
                if (adminrb.Checked)
                {
                    cmd.Parameters.AddWithValue("@Admin", "true");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Admin", "false");
                }
            }
            cmd.ExecuteNonQuery();
            if (typebox.Text == "Undergrad")
            {
                marks.Parameters.AddWithValue("@Id", int.Parse(reg.Text));
                marks.Parameters.AddWithValue("@CC319", "CC319 Advanced-Programming U U U U");
                marks.Parameters.AddWithValue("@CC317", "CC317 Digital-Systems U U U U");
                marks.Parameters.AddWithValue("@NE466", "NE466 Environmental-Science U U U U");
                marks.Parameters.AddWithValue("@EC320", "EC320 Communication-Theory U U U U");
                marks.Parameters.AddWithValue("@EC339", "EC339 Electronics-II U U U U");
                marks.Parameters.AddWithValue("@BA323", "BA323 Mathematics-V U U U U");
                marks.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Added person to database!");
        }




        private void materialButton2_Click(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Show();
            this.Hide();
        }
    }
}