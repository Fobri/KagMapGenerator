﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
