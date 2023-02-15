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
    public partial class MessageBoxVidXPic : Form
    {
        //Videos vidForm = new Videos();
        public static string path;
        public static bool form1hide;

        public MessageBoxVidXPic()
        {
            InitializeComponent();
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose Picture/Video";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;...)|*.BMP;*.JPG;*.GIF;*.jpeg;*.jfif;*.pjpeg;*.pjp;*.png|All files (*.*)|*.*";
            ofd.ShowDialog();
            path = ofd.FileName;
            if (path != "")
            {
                Pictures picForm = new Pictures(new Bitmap(path));
                picForm.Show();
                form1hide = true;
                this.Close();
            }
            else
                MessageBox.Show("ERROR no path choosen");
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose Picture/Video";
            ofd.Filter = "Video Files(*.MP4;*.MOV)|*.mp4;*.mov|All files (*.*)|*.*";
            ofd.ShowDialog();
            path = ofd.FileName;
            if (path != "")
            {
                //vidForm.Show();
                form1hide = true;
                this.Close();
            }
            else
                MessageBox.Show("ERROR no path choosen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1hide = false;
        }
    }
}
