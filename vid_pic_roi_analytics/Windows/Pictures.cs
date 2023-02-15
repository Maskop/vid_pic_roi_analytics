using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace vid_pic_roi_analytics.Windows
{
    public partial class Pictures : Form
    {
        //variables
        Objects.Serialization saver = new Objects.Serialization();
        readonly Timer tick = new Timer();
        List<Objects.ROI> savedROI = new List<Objects.ROI>();
        List<string> lastOpened = new List<string>();
        private Size formScale; //size of form
        private Rectangle lastROIrectangle;
        private Rectangle zoomedRectangle;
        private Bitmap originalImage;
        private Bitmap Image; //Image
        private int nodeSelect = 0; //current node settings
        private int IndexOfROI = 0; //current index of ROI
        private double imageRes; //image resolution
        private double imageScale; //scale of image
        private double zoomScaleX; //scale of zoom X
        private double zoomScaleY;  //scale of zoom Y
        private bool ROIdrawnNotSaved = false; //if false, ROI is only drawn on screen but still not added
        private bool zoomed = false;
        private bool saved = false;
        private bool formClosed = false;

        //main code
        public Pictures(Bitmap image)
        {
            InitializeComponent();

            this.Image = image;

            tick.Interval = (int)TimeSpan.FromMilliseconds(1000).TotalMilliseconds;
            tick.Tick += EveryTick;
        }

        public Pictures(Objects.Save load)
        {
            InitializeComponent();

            this.Image = load.picture;
            this.savedROI = load.roiList;

            tick.Interval = (int)TimeSpan.FromMilliseconds(1000).TotalMilliseconds;
            tick.Tick += EveryTick;
        }

        private void Pictures_Load(object sender, EventArgs e)
        {
            originalImage = Image;
            pictureBox.Location = new Point(0, 0);
            SetPictureBox(Image, pictureBox, imagePanel);
            formScale = this.Size;
            tick.Enabled = true;
            using (StreamReader sr = new StreamReader(@"lastOpened.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lastOpened.Add(line);
                }
            }
            if (savedROI.Count != 0)
            {
                existingROIselection.Items.Clear();
                foreach (Objects.ROI roi in savedROI)
                {
                    if (roi.rectangle != null)
                        existingROIselection.Items.Add("Rectangle" + roi.index);
                    IndexOfROI = roi.index + 1;
                }
            }
        }
        private void ControlTable_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "zoomIn":
                    nodeSelect = 1;
                    break;
                case "resetImg":
                    nodeSelect = 2;
                    SetPictureBox(Image, pictureBox, imagePanel);
                    zoomed = false;
                    break;
                case "ROIr":
                    nodeSelect = 3;
                    break;
                case "ROIc":
                    nodeSelect = 4;
                    break;
                case "ROIfs":
                    nodeSelect = 5;
                    break;
            }    
        }
        private void Pictures_FormClosing(object sender, FormClosingEventArgs e)
        {
            formClosed = true;
            if (MessageBox.Show("Do you want to save?", "Save?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                Save();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
        private void BWbutton_Click(object sender, EventArgs e)
        {
            Image = bw(Image);
            SetPictureBox(Image, pictureBox, imagePanel);
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
        }

        //set picturebox
        /// <summary>
        /// 
        /// </summary>
        /// <param name="image">Image to set as image...</param>
        /// <param name="pb">Picturebox to set the image in...</param>
        /// <param name="ip">Image Panel; Panel witch is the pictureBox in...</param>
        private void SetPictureBox(Bitmap image, PictureBox pb, Panel ip)
        {
            if (image == null)
                return;
            else if (image.Width < image.Height) //when it is portrait resulution
            {
                //image settings
                imageRes = (double)image.Height / (double)image.Width;
                pb.Height = ip.Height;
                pb.Width = (int)((double)ip.Height / imageRes);
                pb.Image = image;
                pb.Update();
                imageScale = (double)image.Width / (double)ip.Width;
            }
            else if (image.Width > image.Height) //when it is landscape resulution
            {
                imageRes = (double)image.Width / (double)image.Height;
                if (ip.Height > (int)((double)ip.Width / imageRes))
                {
                    pb.Width = ip.Width;
                    pb.Height = (int)((double)ip.Width / imageRes);
                }
                else
                {
                    pb.Width = (int)((double)ip.Height * imageRes);
                    pb.Height = ip.Height;
                }
                pb.Image = image;
                pb.Update();
                imageScale = (double)image.Width / (double)ip.Width;
            }
            else //when in 1:1 resolution
            {
                pb.Width = ip.Height;
                pb.Height = ip.Height;
                pb.Image = image;
                pb.Update();
                imageScale = (double)image.Width / (double)ip.Width;
            }
        }
        private void ZoomIn(PictureBox pb, Panel ip, Rectangle rect, double pictureScale)
        {
            Size selectedPartOfImageSize = new Size((int)((double)rect.Width * pictureScale), (int)((double)rect.Height * pictureScale));
            Point selectedPartOfImageLocation = new Point((int)((double)rect.X * pictureScale), (int)((double)rect.Y * pictureScale));
            Rectangle rec = new Rectangle(selectedPartOfImageLocation, selectedPartOfImageSize);
            Bitmap bitmap = (Bitmap)pb.Image;
            if (selectedPartOfImageSize.Width < 1 || selectedPartOfImageSize.Height < 1 || isBiggerThanBorder(bitmap, rec))
                MessageBox.Show("You can't zoom in any more or you are out of bounds!", "Error");
            else
            {
                zoomed = true;
                zoomedRectangle = rect;
                bitmap = bitmap.Clone(rec, pb.Image.PixelFormat);
                zoomScaleX = (double)pb.Image.Width / (double)bitmap.Width;
                zoomScaleY = (double)pb.Image.Height / (double)bitmap.Height;
                pb.Image = bitmap;
                SetPictureBox(bitmap, pb, ip);
            }
        }
        private bool isBiggerThanBorder(Bitmap border, Rectangle rec)
        {
            int endOfRectangleHeight = rec.Y + rec.Height; //end of rectangle in the picture height
            int endOfRectangleWidth = rec.X + rec.Width; //end of rectangle in the picture width
            int endOfRectangleHeightZero = rec.Y - rec.Height; //end of rectangle in the picture height
            int endOfRectangleWidthZero = rec.X - rec.Width; //end of rectangle in the picture width
            if (endOfRectangleWidth <= border.Width && endOfRectangleHeight <= border.Height /*&& endOfRectangleWidthZero > 0 && endOfRectangleHeightZero > 0*/)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //mouse selection
        private Point mdown;

        private void imagePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (nodeSelect == 1 || nodeSelect == 3)
            {
                DrawRectangle(e);
            }
        }
        private void imagePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = e.Location;
            ROIdrawnNotSaved = true;
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (mdown != null && nodeSelect == 1)
            {
                ROIdrawnNotSaved = false;
                ZoomIn(pictureBox, imagePanel, GetRectangle(mdown, e.Location), imageScale);
            }
            else if (mdown != null && nodeSelect == 3)
            {
                Rectangle rect = GetRectangle(mdown, e.Location);
                using (Graphics g = pictureBox.CreateGraphics())
                {
                    g.DrawRectangle(Pens.DarkBlue, rect);
                }
                lastROIrectangle = rect;
            }
        }

        //draw section
        private static Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
        }
        private void DrawRectangle(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox.Refresh();
                using (Graphics g = pictureBox.CreateGraphics())
                {
                    Rectangle rect = GetRectangle(mdown, e.Location);
                    g.DrawRectangle(Pens.Black, rect);
                }
            }
        }

        //bw
        public Bitmap bw(Bitmap image)
        {
            Bitmap newbmp = image;

            for (int row = 0; row < image.Width; row++) // Indicates row number
            {

                for (int column = 0; column < image.Height; column++) // Indicate column number
                {

                    var colorValue = image.GetPixel(row, column); // Get the color pixel

                    var averageValue = ((int)colorValue.R + (int)colorValue.G + (int)colorValue.B) / 3; // get the average for black and white

                    newbmp.SetPixel(row, column, Color.FromArgb(averageValue, averageValue, averageValue)); // Set the value to new pixel
                }

            }
            return newbmp;
        }

        //autosize
        private void Pictures_SizeChanged(object sender, EventArgs e)
        {
            double beforeW = pictureBox.Width;
            double beforeH = pictureBox.Height;
            SetPictureBox((Bitmap)pictureBox.Image, pictureBox, imagePanel);
            double formScaledW = pictureBox.Width / beforeW;
            double formScaledH = pictureBox.Height / beforeH;
            for (int i = 0; i < savedROI.Count; i++)
            {
                savedROI[i].rectangle.Width = (int)((double)savedROI[i].rectangle.Width * formScaledW);
                savedROI[i].rectangle.Height = (int)((double)savedROI[i].rectangle.Height * formScaledH);
                savedROI[i].rectangle.X = (int)((double)savedROI[i].rectangle.X * formScaledW);
                savedROI[i].rectangle.Y = (int)((double)savedROI[i].rectangle.Y * formScaledH);
                if (savedROI[i].rectangle.Width == 0)
                    savedROI[i].rectangle.Width += 1;
                if (savedROI[i].rectangle.Height == 0)
                    savedROI[i].rectangle.Height += 1;
            }
        }

        //ROI
        private void addNewRoi_Click(object sender, EventArgs e)
        {
            ROIdrawnNotSaved = false;
            bool duplicate = false;
            Objects.ROI roi;
            for (int i = 0; savedROI.Count() > i; i++)
            {
                if (savedROI[i].rectangle == lastROIrectangle)
                    duplicate = true;
            }
            if (!duplicate)
            {
                if (nodeSelect == 3)
                {
                    Bitmap ROIinside = getBitmapInArea(pictureBox, lastROIrectangle, imageScale);
                    roi = new Objects.ROI(lastROIrectangle, IndexOfROI, ROIinside);
                    savedROI.Add(roi);
                    existingROIselection.Items.Add("Rectangle" + IndexOfROI, true);
                    IndexOfROI++;
                }
            }
        }
        private void ResetDrawnROIButton_Click(object sender, EventArgs e)
        {
            ROIdrawnNotSaved = false;
            SetPictureBox((Bitmap)pictureBox.Image, pictureBox, imagePanel);
        }
        private void DeleteRoi_Click(object sender, EventArgs e)
        {
            if (!(existingROIselection.SelectedIndex == -1))
            {
                savedROI.RemoveAt(existingROIselection.SelectedIndex);
                existingROIselection.Items.RemoveAt(existingROIselection.SelectedIndex);
                selectedROIpictureBox.Dispose();
                selectedROIpictureBox.Refresh();
            }
        }
        private void existingROIselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (existingROIselection.SelectedIndex >= 0)
            {
                selectedROIpictureBox.Image = savedROI[existingROIselection.SelectedIndex].bitmap;
                selectedROIpictureBox.Refresh();
                double[] averageRGB = analyze(savedROI[existingROIselection.SelectedIndex].bitmap);
                RedL.Text = "Red: " + averageRGB[0].ToString();
                GreenL.Text = "Green: " + averageRGB[1].ToString();
                BlueL.Text = "Blue: " + averageRGB[2].ToString();
                ShowColourPB.BackColor = Color.FromArgb((int)averageRGB[0], (int)averageRGB[1], (int)averageRGB[2]);
            }
        }
        private Bitmap getBitmapInArea(PictureBox pb, Rectangle rect, double pictureScale)
        {
            Size selectedPartOfImageSize = new Size((int)((double)rect.Width * pictureScale), (int)((double)rect.Height * pictureScale));
            Point selectedPartOfImageLocation = new Point((int)((double)rect.X * pictureScale), (int)((double)rect.Y * pictureScale));
            Rectangle rec = new Rectangle(selectedPartOfImageLocation, selectedPartOfImageSize);
            Bitmap bitmap = (Bitmap)pb.Image;
            bitmap = bitmap.Clone(rec, pb.Image.PixelFormat);
            return bitmap;
        }

        //saver
        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Save()
        {
            if (!saved)
            {
                SaveForm saveForm = new SaveForm(new Objects.Save(Image, savedROI));
                saveForm.ShowDialog();
                saved = SaveForm.saved;
                StreamWriter sw = new StreamWriter(@"lastOpened.txt", false);
                sw.WriteLine(SaveForm.currentPath);
                foreach (string path in lastOpened)
                {
                    if (path != SaveForm.currentPath)
                        sw.WriteLine(path);
                }
                sw.Close();
            }
            else
            {
                saver.runSave(SaveForm.currentPath, new Objects.Save(Image, savedROI));
            }
        }

        //analyze
        private double[] analyze(Bitmap image)
        {
            //int[,,] pixels = new int[image.Width, image.Height, 3];
            int colorValR = 0;
            int colorValG = 0;
            int colorValB = 0;
            for (int row = 0; row < image.Width; row++)
            {
                for (int column = 0; column < image.Height; column++)
                {
                    var colorValue = image.GetPixel(row, column);
                    colorValR += colorValue.R;
                    colorValG += colorValue.G;
                    colorValB += colorValue.B;
                    //pixels[row, column, 0] = colorValue.R;
                    //pixels[row, column, 1] = colorValue.G;
                    //pixels[row, column, 2] = colorValue.B;
                }

            }
            double[] average = new double[] { 
                colorValR / (image.Width * image.Height), 
                colorValG / (image.Height * image.Width), 
                colorValB / (image.Width * image.Height) 
            };
            return average;
        }

        //objects
        /*
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }
        */
        private void DrawROIinZoom()
        {
            using (Graphics g = pictureBox.CreateGraphics())
            {
                g.Clear(BackColor);
                SetPictureBox((Bitmap)pictureBox.Image, pictureBox, imagePanel);

                for (int i = 0; i < existingROIselection.Items.Count; i++)
                {
                    if (existingROIselection.GetItemChecked(i))
                    {
                        Rectangle rectangle = savedROI[i].rectangle;
                        rectangle.X = (int)(((double)savedROI[i].rectangle.X - zoomedRectangle.X) * zoomScaleX);
                        rectangle.Y = (int)(((double)savedROI[i].rectangle.Y - zoomedRectangle.Y) * zoomScaleY);
                        rectangle.Width = (int)((double)savedROI[i].rectangle.Width * zoomScaleX);
                        rectangle.Height = (int)((double)savedROI[i].rectangle.Height * zoomScaleY);
                        g.DrawRectangle(Pens.AliceBlue, rectangle);
                    }
                }
            }
        }

        private void EveryTick(object sender, EventArgs e) //every second
        {
            if (!formClosed)
            {
                if (!ROIdrawnNotSaved)
                {
                    if (ROIOnScreenCheckBox.Checked)
                    {
                        if (!zoomed)
                        {
                            using (Graphics g = pictureBox.CreateGraphics())
                            {
                                g.Clear(BackColor);
                                SetPictureBox((Bitmap)pictureBox.Image, pictureBox, imagePanel);

                                for (int i = 0; i < existingROIselection.Items.Count; i++)
                                {
                                    if (existingROIselection.GetItemChecked(i))
                                    {
                                        g.DrawRectangle(Pens.AliceBlue, savedROI[i].rectangle);
                                    }
                                }
                            }
                        }
                        else
                            DrawROIinZoom();
                    }
                    else
                        SetPictureBox((Bitmap)pictureBox.Image, pictureBox, imagePanel);
                }
            }
        }
    }
}
