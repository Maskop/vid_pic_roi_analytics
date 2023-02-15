using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vid_pic_roi_analytics.ImageTools
{
    internal class bw
    {
        public object convert(string filePath)
        {
            var originalbmp = new Bitmap(Bitmap.FromFile(filePath)); // Load the  image
            Bitmap newbmp = originalbmp;
            
            for (int row = 0; row < originalbmp.Width; row++) // Indicates row number
            {

                for (int column = 0; column < originalbmp.Height; column++) // Indicate column number
                {

                    var colorValue = originalbmp.GetPixel(row, column); // Get the color pixel

                    var averageValue = ((int)colorValue.R + (int)colorValue.B + (int)colorValue.G) / 3; // get the average for black and white

                    newbmp.SetPixel(row, column, Color.FromArgb(averageValue, averageValue, averageValue)); // Set the value to new pixel

                }

            }
            return newbmp;
        }
    }

}