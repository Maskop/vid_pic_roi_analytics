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
    public partial class SaveForm : Form
    {
        Objects.Serialization saver = new Objects.Serialization();
        object save;
        bool alreadySaid = false;
        public static string currentPath;
        public static bool saved;

        public SaveForm(object save)
        {
            InitializeComponent();
            this.save = save;
            this.KeyPreview = true;
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {

        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';

            if (selectedNameTextBox.Text.Count() == 10 && !alreadySaid)
            {
                MessageBox.Show("Name length limit is 10");
                alreadySaid = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!selectedPathTextBox.Text.Contains("Directory Path...") || !selectedNameTextBox.Text.Contains("Name..."))
            {
                currentPath = selectedPathTextBox.Text + @"\" + selectedNameTextBox.Text + ".txt";
                saver.runSave(currentPath, save);
                this.Close();
                saved = true;
            }
            else
                MessageBox.Show("Error: Wrong Name or Path");
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            selectedPathTextBox.Text = fbd.SelectedPath;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            saved = false;
            this.Close();
        }
    }
}
