using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmTitle : Form
    {
     
        public static FrmTitle instance = null;

        private FrmTitle()
        {
            InitializeComponent();
        }

        public static FrmTitle GetInstance()
        {
            instance = new FrmTitle();
            return instance;
        }
    }
}

