using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Student_regestration
{
    public partial class AddtoDB : Form
    {


        public static string databaseConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aliba\\Desktop\\Student_regestration\\Student-Portal-C-\\Student_regestration\\Student_regestration\\Database1.mdf;Integrated Security=True";
        public AddtoDB()
        {
            InitializeComponent();
            List<Course> courses = Course.loadCourses();
            foreach (Course x in courses)
            {
                checkedListBox1.Items.Add(x.Code);
            }
        }
        //Add
        private void materialButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(databaseConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users ( Id,Password,Name,Term,DoB,Gender,Type,Admin) values (@Id,@Pass,@Name,@Term,@DoB,@Gender,@Type,@Admin)", con);
            SqlCommand marks = new SqlCommand("insert into marks ( Id,CC319,CC317,NE466,EC320,EC339,BA323,EE328,CC215,CC216,BA224,EC232,EC238,EC218) values (@Id,@CC319,@CC317,@NE466,@EC320,@EC339,@BA323,@EE328,@CC215,@CC216,@BA224,@EC232,@EC238,@EC218)", con);
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
                marks.Parameters.AddWithValue("@EE328", "EE328 Electrical-Power U U U U");
                marks.Parameters.AddWithValue("@BA224", "BA224 Mathematics-IV U U U U");
                marks.Parameters.AddWithValue("@CC215", "CC215 Data-Structure U U U U");
                marks.Parameters.AddWithValue("@CC216", "CC216 Digital-Logic U U U U");
                marks.Parameters.AddWithValue("@EC232", "EC232 Electrical-Circuits-II U U U U");
                marks.Parameters.AddWithValue("@EC238", "EC238 Electronics-I U U U U");
                marks.Parameters.AddWithValue("@EC218", "EC218 Measurements U U U U");
                marks.ExecuteNonQuery();
            }
            for(int i =0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    this.addSubjects(checkedListBox1.Items[i].ToString());
                }
            }
            con.Close();
            MessageBox.Show("Added person to database!");
        }

        private void addSubjects(string mada)
        {
            if (string.IsNullOrEmpty(mada)) { return; }
            if (typebox.Text == "Teaching Assistant")
            {
                string TAList= "";
                SqlConnection con = new SqlConnection(databaseConnection);
                con.Open();
                SqlCommand read = new SqlCommand("SELECT * from Courses Where Code = @Code", con);
                SqlCommand cmd = new SqlCommand("update Courses SET TAs = @ID Where Code = @Code", con);
                read.Parameters.AddWithValue("@Code", mada);
                cmd.Parameters.AddWithValue("@Code", mada);
                using (SqlDataReader reader = read.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        TAList = (reg.Text);
                        //TAList = reader["TAs"].ToString();
                        //TAList += "-" + int.Parse(reg.Text);
                    }
                    else
                    {
                        TAList = (reg.Text);
                        //TAList += int.Parse(reg.Text);
                    }
                }
                
                cmd.Parameters.AddWithValue("@ID", TAList);
                cmd.ExecuteNonQuery();
                con.Close();
            } 
            else if (typebox.Text == "Lecturer")
            {
                string LecList = "";
                SqlConnection con = new SqlConnection(databaseConnection);
                con.Open();
                SqlCommand read = new SqlCommand("SELECT * from Courses Where Code = @Code", con);
                SqlCommand cmd = new SqlCommand("update Courses SET Lecturers = @ID Where Code = @Code", con);
                read.Parameters.AddWithValue("@Code", mada);
                cmd.Parameters.AddWithValue("@Code", mada);
                using (SqlDataReader reader = read.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        LecList=(reg.Text);
                       //LecList = reader["Lecturers"].ToString();
                        //LecList += "-" + int.Parse(reg.Text);
                    }
                    else
                    {
                        LecList = (reg.Text);
                        //LecList += int.Parse(reg.Text);
                    }
                }
                cmd.Parameters.AddWithValue("@ID", LecList);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Show();
            this.Hide();
        }

        private void typebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typebox.Text == "Lecturer" || typebox.Text == "Teaching Assistant")
            {
                Staffonly.Enabled = true;
            }
            else
            {
                Staffonly.Enabled = false;
            }
        }
    }
}