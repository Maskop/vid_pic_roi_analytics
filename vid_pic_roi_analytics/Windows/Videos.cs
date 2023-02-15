using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vid_pic_roi_analytics.Windows
{
    public partial class Videos : Form 
    {

        public Videos()
        {
            InitializeComponent();
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            vidPlayer.URL = MessageBoxVidXPic.path;
        }

        private void Videos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit Program?", "Exit?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                e.Cancel = true;
            else
                Application.Exit();
        }
    }
}
