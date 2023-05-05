using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace KagMapGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void genButton_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Png|*.png";
            saveFileDialog1.Title = "Save map";
            saveFileDialog1.FileName = "mykagmap";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.mapImage.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }

        private void mapImage_Paint(object sender, PaintEventArgs e)
        {
            // Disable image interpolation and anti-aliasing
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            // Draw the image in the PictureBox
            if (mapImage.Image == null) return;
            e.Graphics.DrawImage(mapImage.Image, mapImage.ClientRectangle);
        }

        private void steepnessInput_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void frequencyInput_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void stoneChance_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void grassChance_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void bedrockRoughness_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void bedrockDepth_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void treeInterval_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void treeCount_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void midshopCount_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void flagInterval_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void flagCount_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void redzone_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }

        private void tentEdgeDst_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false,false);
        }


        private void frequencyInput_Validated(object sender, EventArgs e)
        {
            Program.Generate(false, false);
        }

        private void frequencyInput_TextChanged_1(object sender, EventArgs e)
        {
            Program.Generate(false, false);
        }

        private void surfaceLevel_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false, false);

        }

        private void flatness_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false, false);

        }

        private void island_CheckedChanged(object sender, EventArgs e)
        {
            Program.Generate(false, false);

        }

        private void cave_CheckedChanged(object sender, EventArgs e)
        {
            Program.Generate(false, false);

        }

        private void generateBase_CheckedChanged(object sender, EventArgs e)
        {
            Program.Generate(false, false);

        }

        private void randomizeBaseSeed_CheckedChanged(object sender, EventArgs e)
        {
            Program.Generate(false, false);

        }

        private void baseSizeX_TextChanged(object sender, EventArgs e)
        {
            Program.Generate(false, false);

        }

        private void baseSizeY_TextChanged(object sender, EventArgs e)
        {

            Program.Generate(false, false);
        }

        private void blockSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(blockName.Text) || string.IsNullOrEmpty(blockWeight.Text) || blockPicture.Image == null) {
                MessageBox.Show("A block must have a name, weight, and a picture");
                return;
            }
            blockList.Items.Add(new BaseBlockListItem(blockName.Text, blockLeft.Checked, blockRight.Checked, blockUp.Checked, blockDown.Checked, int.Parse(blockWeight.Text), (Bitmap)blockPicture.Image));
            blockPicture.Image = null;
            blockName.Clear();
            blockWeight.Text = "3";
            blockLeft.Checked = false;
            blockRight.Checked = false;
            blockUp.Checked = false;
            blockDown.Checked = false;
            BaseBuilder.SetBlocks(blockList);
        }

        private void blockRemove_Click(object sender, EventArgs e)
        {
            if(blockList.Items.Count > 0)
            {
                blockList.Items.Remove(blockList.SelectedItems[0]);
            }

            BaseBuilder.SetBlocks(blockList);
        }

        private void blockOpenImage_Click(object sender, EventArgs e)
        {
            // Create a new OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to accept only PNG images
            openFileDialog.Filter = "PNG Images (*.png)|*.png";


            // Display the dialog and get the result
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file, so you can use the FileName property to get the full path of the selected file
                string selectedFileName = openFileDialog.FileName;
                Bitmap image = new Bitmap(selectedFileName);
                if(image.Width != 7 || image.Height != 4)
                {
                    MessageBox.Show("Image must be a width of 7 and a height of 4");
                    return;
                }
                // Do something with the file...
                blockPicture.Image = image;
            }


        }

        private void blockPicture_Paint(object sender, PaintEventArgs e)
        {

            // Disable image interpolation and anti-aliasing
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            // Draw the image in the PictureBox
            if (blockPicture.Image == null) return;
            e.Graphics.DrawImage(blockPicture.Image, blockPicture.ClientRectangle);
        }

        private void blockList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            BaseBlockListItem selected = e.Item as BaseBlockListItem;
            blockPicture.Image = selected.Image;
            blockName.Text = selected.Name;
            blockWeight.Text = selected.Weight.ToString();
            blockLeft.Checked = selected.Left;
            blockRight.Checked = selected.Right;
            blockUp.Checked = selected.Up;
            blockDown.Checked = selected.Down;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            blockPicture.Image = null;
            blockName.Clear();
            blockWeight.Text = "3";
            blockLeft.Checked = false;
            blockRight.Checked = false;
            blockUp.Checked = false;
            blockDown.Checked = false;
        }

        private void savePreset_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Cfg|*.cfg";
            saveFileDialog1.Title = "Save block preset";
            saveFileDialog1.FileName = "buildingBlocks";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:

                        XmlSerializer serializer = new XmlSerializer(typeof(BaseBlockListItem.SerializedData[]));
                        BaseBlockListItem.SerializedData[] toSave = new BaseBlockListItem.SerializedData[blockList.Items.Count];
                        for(int i = 0; i < toSave.Length; i++)
                        {
                            toSave[i] = new BaseBlockListItem.SerializedData(blockList.Items[i] as BaseBlockListItem);
                        }

                        serializer.Serialize(fs, toSave);
                        break;
                }

                fs.Close();
            }
        }

        private void loadPreset_Click(object sender, EventArgs e)
        {
            // Create a new OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to accept only PNG images
            openFileDialog.Filter = "Cfg|*.cfg";


            // Display the dialog and get the result
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file, so you can use the FileName property to get the full path of the selected file
                string selectedFileName = openFileDialog.FileName;
                using (FileStream stream = new FileStream(selectedFileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(BaseBlockListItem.SerializedData[]));
                    BaseBlockListItem.SerializedData[] data = (BaseBlockListItem.SerializedData[])serializer.Deserialize(stream);

                    blockList.Items.Clear();
                    for(int i = 0; i < data.Length; i++)
                    {
                        blockList.Items.Add(new BaseBlockListItem(data[i]));
                    }
                }
            }
            BaseBuilder.SetBlocks(blockList);
        }
    }
}
