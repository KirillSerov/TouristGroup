using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TouristsGroup
{
    public class SaveData
    {
        private string filename;
        public SaveData(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
                throw new ArgumentNullException(nameof(filename));
            this.filename = filename;
        }

        public int Save(Group group)
        {
            if (group == null)
                return -1;

            using (FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Group), new Type[] {typeof(Cap), typeof(Jacket) , typeof(Shoes) , typeof(Backpack),typeof(Water),typeof(CannedFood)});
                xml.Serialize(file, group);

            }
            return 1;
        }
    }
}
