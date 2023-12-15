using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_regestration
{
    public partial class AdvisorPanel : Form
    {
        public AdvisorPanel()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            CreateC CC = new CreateC();
            CC.Show();
            this.Hide();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Register RG = new Register();
            RG.Show();
            this.Hide();
        }
    }
}
