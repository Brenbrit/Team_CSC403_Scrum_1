using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmKillOrSpare : Form
    {
        private int ratio = 0;
        public FrmKillOrSpare()
        {
            InitializeComponent();
        }

        public int getRatio() { return ratio; }
        public void setRatio(int n) { this.ratio = n; }

        private void FrmKillOrSpare_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Kill_Click(object sender, EventArgs e)
        {
            this.setRatio(getRatio() - 1);
            this.Hide();
        }

        private void Spare_Click(object sender, EventArgs e)
        {
            this.setRatio(getRatio() + 1);
            this.Hide();
        }
    }
}
