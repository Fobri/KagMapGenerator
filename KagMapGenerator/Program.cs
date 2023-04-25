using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KagMapGenerator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static Form1 window;
        static MapImageGenerator generator;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new Form1();
            window.genButton.MouseClick += Generate;
            generator = new MapImageGenerator();
            Application.Run(window);
        }

        static void Generate(object sender, EventArgs e)
        {
            var xSize = int.Parse(window.xSize.Text);
            var ySize = int.Parse(window.ySize.Text);
            float freq = int.Parse(window.frequencyInput.Text) / 1000f;
            float steepness = int.Parse(window.steepnessInput.Text);
            bool randomSeed = window.randomSeed.Checked;
            int seed = 0;
            if (randomSeed)
            {
                seed = new Random().Next(0,99999);
                window.seedText.Text = seed.ToString();
            }
            else
            {
                seed = int.Parse(window.seedText.Text);
            }
            bool cave = window.cave.Checked;
            bool island = window.island.Checked;
            int grassChance = int.Parse(window.grassChance.Text);
            int redzone = int.Parse(window.redzone.Text);
            int flagCount = int.Parse(window.flagCount.Text);
            int flagInterval = int.Parse(window.flagInterval.Text);
            int stoneChance = int.Parse(window.stoneChance.Text);

            window.mapImage.Image = generator.GetMapImage(xSize, ySize, freq, steepness, seed, cave, island, grassChance, stoneChance, redzone, flagCount, flagInterval);
            window.mapImage.Update();
        }
    }
}
