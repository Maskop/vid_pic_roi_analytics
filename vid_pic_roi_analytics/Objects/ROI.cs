using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vid_pic_roi_analytics.Objects
{
    [Serializable]
    public class ROI: List<ROI>
    {
        public Rectangle rectangle;
        public int index;
        public Bitmap bitmap;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rec">rectangle</param>
        /// <param name="i">index of roi</param>
        /// <param name="bitmap">the inside of ROI</param>
        public ROI(Rectangle rec, int i, Bitmap bitmap)
        {
            this.rectangle = rec;
            this.index = i;
            this.bitmap = bitmap;
        }

        
        /*
        /// <summary>
        /// ellipse
        /// </summary>
        /// <param name="rec"></param>
        /// <param name="i"></param>
        public ROI(Rectangle rec, int i)
        {
            
        }*/
    }
}
