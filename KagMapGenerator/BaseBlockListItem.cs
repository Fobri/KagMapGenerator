using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KagMapGenerator
{
    public class BaseBlockListItem : ListViewItem
    {
        public string Name { get; set; }
        public bool Left { get; set; }
        public bool Right { get; set; }
        public bool Up { get; set; }
        public bool Down { get; set; }
        public int Weight { get; set; }
        public Bitmap Image { get; set; }
        public string RestrictDirections
        {
            get
            {
                return (Left ? "Left, " : "") + (Right ? "Right, " : "") + (Up ? "Up, " : "") + (Down ? "Down" : "");
            }
        }

        public BaseBlockListItem(string name, bool left, bool right, bool up, bool down, int weight, Bitmap image)
        {
            Name = name;
            this.Left = left;
            this.Right = right;
            this.Up = up;
            this.Down = down;
            Weight = weight;
            Image = image;

            Text = Name;
            SubItems.Add(RestrictDirections);
            SubItems.Add(Weight.ToString());
        }
        public BaseBlockListItem(SerializedData data) 
        {
            Name = data.Name;
            this.Left = data.Left;
            this.Right = data.Right;
            this.Up = data.Up;
            this.Down = data.Down;
            Weight = data.Weight;
            using (var stream = new MemoryStream(data.Image))
            {
                Image = new Bitmap(stream);
            }

            Text = Name;
            SubItems.Add(RestrictDirections);
            SubItems.Add(Weight.ToString());
        }
        public Color[,] GetColorArray()
        {
            Color[,] result = new Color[4, 7];
            for(int x = 0; x < 7; x++)
            {
                for(int y = 0; y < 4; y++)
                {
                    result[y, x] = Image.GetPixel(x, y);
                }
            }
            return result;
        }

        [Serializable]
        public class SerializedData
        {

            [XmlElement]
            public string Name { get; set; }
            [XmlElement]
            public bool Left { get; set; }
            [XmlElement]
            public bool Right { get; set; }
            [XmlElement]
            public bool Up { get; set; }
            [XmlElement]
            public bool Down { get; set; }
            [XmlElement]
            public int Weight { get; set; }
            [XmlElement]
            public byte[] Image { get; set; }
            public SerializedData(BaseBlockListItem item)
            {
                Name = item.Name;
                Left = item.Left;
                Right = item.Right;
                Up = item.Up;
                Down = item.Down;
                Weight = item.Weight;
                if (item.Image == null) throw new Exception("Something wrong...");
                using (var stream = new MemoryStream())
                {
                    item.Image.Save(stream, item.Image.RawFormat);
                    Image = stream.ToArray();
                }
            }
            public SerializedData() { }
        }
    }
}
