﻿using System;
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
    public partial class FrmTitle : Form
    {
        public static FrmTitle instance = null;
        public FrmTitle()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCharSelect CharSelect = new FrmCharSelect();
            CharSelect.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FrmTitle_Load(object sender, EventArgs e)
        {

        }
    }
}
