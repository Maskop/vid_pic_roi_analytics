using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vid_pic_roi_analytics.Objects
{
    [Serializable]
    public class Save
    {
        public Bitmap picture;
        public string videoPath;
        public List<ROI> roiList;

        public Save(Bitmap picture, List<ROI> roiList)
        {
            this.picture = picture;
            this.roiList = roiList;
        }

        public Save(string videoPath, List<ROI> roiList)
        {
            this.videoPath = videoPath;
            this.roiList = roiList;
        }
    }
}
