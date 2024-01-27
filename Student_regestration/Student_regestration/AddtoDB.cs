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
        List<Course> courses = Course.loadCourses();
        public AddtoDB()
        {
            InitializeComponent();
            
            foreach (Course x in courses)
            {
                checkedListBox1.Items.Add(x.Code);
            }
            typebox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //Add
        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(databaseConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Users ( Id,Password,Name,Term,DoB,Gender,Type,Admin) values (@Id,@Pass,@Name,@Term,@DoB,@Gender,@Type,@Admin)", con);
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
                    InsertDataIntoMarksTable(courses, int.Parse(reg.Text));
                }
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        this.addSubjects(checkedListBox1.Items[i].ToString());
                    }
                }
                con.Close();
                errormes.Visible = false;
                MessageBox.Show("Added person to database!");
            }
            catch (Exception ex)
            {
                errormes.Visible = true;
                errormes.Text = "Some of your inputs are incorrect check again..";
            }



        }


        private void addSubjects(string mada)
        {
            if (string.IsNullOrEmpty(mada)) { return; }
            if (typebox.Text == "Teaching Assistant")
            {
                string TAList = "";
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
                    //Comments are old functions that cannot be handled right now
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
                        LecList = (reg.Text);
                        //LecList = reader["Lecturers"].ToString();
                        //LecList += "-" + int.Parse(reg.Text);

                    }
                    else
                    {
                        LecList = (reg.Text);
                        //LecList += int.Parse(reg.Text);
                    }
                    //Comments are old functions that cannot be handled right now
                }
                cmd.Parameters.AddWithValue("@ID", LecList);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        static void InsertDataIntoMarksTable(List<Course> courses, int Id)
        {
            using (SqlConnection con = new SqlConnection(databaseConnection))
            {
                con.Open();

                string columns = "Id," + string.Join(",", courses.Select(course => course.Code));
                string values = "@Id," + string.Join(",", courses.Select(course => $"@{course.Code}"));

                string sqlCommandText = $"INSERT INTO marks ({columns}) VALUES ({values})";

                using (SqlCommand marks = new SqlCommand(sqlCommandText, con))
                {
                    marks.Parameters.AddWithValue("@Id", Id); 

                    foreach (Course course in courses)
                    {
                        marks.Parameters.AddWithValue($"@{course.Code}", $"{course.Code} {course.Name} U U U U");
                    }

                    marks.ExecuteNonQuery();
                }
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