using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmKillOrSpare : Form
    {
        public static FrmKillOrSpare instance = null;

        private FrmKillOrSpare()
        {
            InitializeComponent();
        }

        public static FrmDeath GetInstance()
        {
            instance = new FrmKillOrSpare();
            return instance;
        }
    }
}

