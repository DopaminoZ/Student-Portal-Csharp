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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            RemoveFromDB RD = new RemoveFromDB();
            RD.Show();
            this.Hide();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            ModifyDB MD = new ModifyDB();
            MD.Show();
            this.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AddtoDB AD = new AddtoDB();
            AD.Show();
            this.Hide();
        }
    }
}
