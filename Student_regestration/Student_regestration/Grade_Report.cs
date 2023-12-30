using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_regestration
{
    public partial class Grade_Report : Form
    {
        public Grade_Report(Undergrad x)
        {
            InitializeComponent();
            x.FetchMarks(this);
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


    }
}
