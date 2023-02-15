using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vid_pic_roi_analytics
{
    public partial class Form1 : Form
    {
        private Windows.MessageBoxVidXPic boxVidXPic = new Windows.MessageBoxVidXPic();
        private Objects.Serialization opener = new Objects.Serialization();
        private List<string> lastOpened = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseProject_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"lastOpened.txt"))
                File.Create(@"lastOpened.txt");
            using (StreamReader sr = new StreamReader(@"lastOpened.txt"))
            {
                string path;
                while ((path = sr.ReadLine()) != null)
                {
                    lastOpened.Add(path);
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            boxVidXPic.ShowDialog();
            if (Windows.MessageBoxVidXPic.form1hide)
                this.Hide();
        }

        private void OpenExistButton_Click(object sender, EventArgs e)
        {
            Objects.Save load;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose save";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                load = opener.runLoad(ofd.FileName);
                if (load != null)
                {
                    Windows.Pictures pic = new Windows.Pictures(load);
                    pic.Show();
                }
            }
            else
                MessageBox.Show("ERROR no path choosen");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
