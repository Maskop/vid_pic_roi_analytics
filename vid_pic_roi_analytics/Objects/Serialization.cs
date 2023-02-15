using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace vid_pic_roi_analytics.Objects
{
    internal class Serialization
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">Path to the folder that it will be saved in...</param>
        /// <param name="nameOfFile">Name of the new file...</param>
        /// <param name="toSerialize">Object that will be saved...</param>
        public void runSave(string path, object toSerialize)
        {
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, toSerialize);
            stream.Close();

        }

        public Save runLoad(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            return (Save)formatter.Deserialize(stream);
        }
    }
}
