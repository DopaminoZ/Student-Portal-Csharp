using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Student_regestration
{
    public partial class AddtoDB : Form
    {

        private Button Yes;
        private Button No;
        private Label Confirm;
        public AddtoDB()
        {
            InitializeComponent();

            Yes = new Button();
            Yes.Text = "Yes";
            Yes.Location = new System.Drawing.Point(492, 468);
            Yes.Click += new EventHandler(Yes_Click);
            Controls.Add(Yes);

            No = new Button();
            No.Text = "No";
            No.Location = new System.Drawing.Point(660, 468);
            No.Click += new EventHandler(No_Click);
            Controls.Add(No);

            Confirm = new Label();
            Confirm.AutoSize = true;
            Confirm.Location = new Point(536, 427);
            Confirm.Size = new Size(174, 15);
            Confirm.TabIndex = 18;
            Confirm.Text = "Are you sure this is the student?";
            this.Controls.Add(Confirm);

            Yes.Visible = false;
            No.Visible = false;
            Confirm.Visible = false;
            materialButton3.Visible = false;
            namemod.ReadOnly = true;
            datemod.Enabled = false;
            termmod.ReadOnly = true;
        }
        //Add
        private void materialButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CQ83DFV\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTab values (@RegisterationNum, @Name, @Term, @DoB)", con);
            cmd.Parameters.AddWithValue("@RegisterationNum", int.Parse(reg.Text));
            cmd.Parameters.AddWithValue("@Name", name.Text);
            cmd.Parameters.AddWithValue("@DoB", dateob.Value);
            cmd.Parameters.AddWithValue("@Term", int.Parse(term.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added student to database!");
        }

        //Delete
        private void Yes_Click(object sender, EventArgs e)
        {
            Yes.Visible = false;
            No.Visible = false;
            Confirm.Visible = false;
            deletename.Text = "Student Name - ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CQ83DFV\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserTab where RegisterationNum = @ID ", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regdel.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            regdel.Text = "";
            regdel.ReadOnly = false;
            MessageBox.Show("Done!");
        }
        private void No_Click(object sender, EventArgs e)
        {
            Yes.Visible = false;
            No.Visible = false;
            Confirm.Visible = false;
            regdel.ReadOnly = false;
            deletename.Text = "Student Name - ";
            regdel.Text = "";
            MessageBox.Show("Reverted first request!");
        }

        private void Del_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CQ83DFV\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM UserTab WHERE RegisterationNum = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regdel.Text));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string studentName = reader["Name"].ToString();
                    deletename.Text = String.Format("Student Name - {0}", studentName);
                    Yes.Visible = true;
                    No.Visible = true;
                    Confirm.Visible = true;
                    regdel.ReadOnly = true;
                }
                else
                {
                    deletename.Text = "Student not found!, try another Reg Num...";
                }
            }
        }
        //Modify
        string newterm, newname;
        string Regid;
        DateTime newdate;
        private void materialButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CQ83DFV\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserTab SET Name = @Name, DoB = @Date, Term = @Term WHERE RegisterationNum = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regmod.Text));
            cmd.Parameters.AddWithValue("@Name", newname);
            cmd.Parameters.AddWithValue("@Term", int.Parse(newterm));
            cmd.Parameters.AddWithValue("@Date", newdate);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Edited the data for user " + Regid);
            materialButton4_Click(sender, e);
            regmod.ReadOnly = false;
            namemod.ReadOnly = true;
            datemod.Enabled = false;
            termmod.ReadOnly = true;
            materialButton4.Visible = true;
            materialButton3.Visible = false;

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CQ83DFV\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTab WHERE RegisterationNum = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(regmod.Text));
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string studentName = reader["Name"].ToString();
                    string date = reader["DoB"].ToString();
                    date = date.Substring(0, 10);
                    if (date[8] == ' ' && date[9] != ' ')
                    {
                        date = date.Substring(0, 9);
                    }
                    Regid = regmod.Text;
                    displaymod.Text = String.Format("Student Name - {0}", studentName);
                    namedisplay.Text = studentName;
                    datedisplay.Text = date;
                    termdisplay.Text = reader["Term"].ToString();
                    regmod.ReadOnly = true;
                    namemod.ReadOnly = false;
                    datemod.Enabled = true;
                    termmod.ReadOnly = false;
                    materialButton4.Visible = false;
                    materialButton3.Visible = true;


                }
                else
                {
                    displaymod.Text = "Student not found!, try another Reg Num...";

                }
            }
        }

        private void termmod_TextChanged(object sender, EventArgs e)
        {
            newterm = termmod.Text;
        }

        private void namemod_TextChanged(object sender, EventArgs e)
        {
            newname = namemod.Text;
        }

        private void datemod_ValueChanged(object sender, EventArgs e)
        {
            newdate = datemod.Value;
        }
    }
}