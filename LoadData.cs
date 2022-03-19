using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TouristsGroup
{
    public class LoadData
    {
        private string filename;
        public LoadData(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
                return;
            this.filename = filename;
        }
        public Group Load()
        {
            Group group = new Group();
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Group), new Type[] { typeof(Cap), typeof(Jacket), typeof(Shoes), typeof(Backpack), typeof(Water), typeof(CannedFood) });
                group = xml.Deserialize(file) as Group;                
            }
            return group;
        }
    }
}
