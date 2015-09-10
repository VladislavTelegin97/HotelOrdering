using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace HotelOrdering.Model
{
    [Serializable]
    class Configuration
    {
        public System.Collections.Generic.Dictionary<int, System.Drawing.Color> configList { get; set; }

        public Configuration() 
        { this.configList = new System.Collections.Generic.Dictionary<int, System.Drawing.Color>(); }

        public static Configuration GetConfiguration()
        {
            using (System.IO.FileStream fStream = System.IO.File.OpenRead(Application.StartupPath + @"/config.ini"))
            {
                return (Configuration)(new BinaryFormatter().Deserialize(fStream)); 
            }
        }

        public void SetConfiguration()
        {
            using (System.IO.FileStream fStream = System.IO.File.Create(Application.StartupPath + @"/config.ini"))
            {
                new BinaryFormatter().Serialize(fStream, this);
            }
        }

        public void ApplyConfiguration(System.Collections.Generic.List<Floor> floorList)
        {
            foreach (Floor f in floorList)
                foreach (System.Windows.Forms.Button b in f)
                {
                    b.BackColor = configList[int.Parse(b.Text)];
                    if (b.BackColor == System.Drawing.Color.Black)
                        b.ForeColor = System.Drawing.Color.White;
                }
        }
    }
}
