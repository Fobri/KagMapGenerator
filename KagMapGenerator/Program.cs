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
        static int originalImageSize;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new Form1();
            window.genButton.MouseClick += Generate;
            generator = new MapImageGenerator();
            originalImageSize = window.mapImage.Size.Width;
            Generate(false, false);
            Application.Run(window);
        }

        static void Generate(object sender, EventArgs e)
        {
            Generate(window.randomSeed.Checked, window.randomizeBaseSeed.Checked);
        }

        public static void Generate(bool randomSeed, bool randomBaseSeed)
        {
            if (!int.TryParse(window.xSize.Text, out int xSize)) return;

            if (!int.TryParse(window.ySize.Text, out int ySize)) return;
            float freq = 0;
            if (!float.TryParse(window.frequencyInput.Text, out freq)) return;
            freq /= 1000f;
            float steepness = 0;
            if (!float.TryParse(window.steepnessInput.Text, out steepness)) return;
            bool cave = window.cave.Checked;
            bool island = window.island.Checked;
            int grassChance = 0;
            if (!int.TryParse(window.grassChance.Text, out grassChance)) return;
            int redzone = 0;
            if (!int.TryParse(window.redzone.Text, out redzone)) return;
            int flagCount = 0;
            if (!int.TryParse(window.flagCount.Text, out flagCount)) return;
            int flagInterval = 0;
            if (!int.TryParse(window.flagInterval.Text, out flagInterval)) return;
            int stoneChance = 0;
            if (!int.TryParse(window.stoneChance.Text, out stoneChance)) return;
            int bedrockDepth = 0;
            if (!int.TryParse(window.bedrockDepth.Text, out bedrockDepth)) return;
            float bedrockRoughness = 0;
            if (!float.TryParse(window.bedrockRoughness.Text, out bedrockRoughness)) return;
            bedrockRoughness /= 50f;
            int treeCount = 0;
            if (!int.TryParse(window.treeCount.Text, out treeCount)) return;
            int treeInterval = 0;
            if (!int.TryParse(window.treeInterval.Text, out treeInterval)) return;
            int tentEdgeDst = 0;
            if (!int.TryParse(window.tentEdgeDst.Text, out tentEdgeDst)) return;
            int midshopCount = 0;
            if (!int.TryParse(window.midshopCount.Text, out midshopCount)) return;
            int surfaceLevel = 0;
            if (!int.TryParse(window.surfaceLevel.Text, out surfaceLevel)) return;
            float flatness = 0;
            if (!float.TryParse(window.flatness.Text, out flatness)) return;
            flatness /= 10f;
            int seed = 0;
            if (randomSeed)
            {
                seed = new Random().Next(0, 99999);
                window.seedText.Text = seed.ToString();
            }
            else
            {
                if (!int.TryParse(window.seedText.Text, out seed)) return;
            }
            //int multiplier = originalImageSize / xSize;
            //window.mapImage.Size = new Size(xSize * multiplier, ySize * multiplier);
            var map = generator.GetMapImage(xSize, ySize, freq, steepness, seed, cave, island, grassChance, stoneChance, redzone, flagCount, flagInterval, bedrockDepth, bedrockRoughness, treeCount, treeInterval, tentEdgeDst, midshopCount, surfaceLevel, flatness, out int2 lastFlagPos);
            if (window.generateBase.Checked)
            {
                if (randomBaseSeed)
                {
                    seed = new Random().Next(0, 99999);
                    window.baseSeed.Text = seed.ToString();
                }
                else
                {
                    if (!int.TryParse(window.baseSeed.Text, out seed)) return;
                }
                BaseBuilder baseBuilder = new BaseBuilder();
                int baseSizeX = 0;
                if (!int.TryParse(window.baseSizeX.Text, out baseSizeX)) return;
                int baseSizeY = 0;
                if (!int.TryParse(window.baseSizeY.Text, out baseSizeY)) return;
                baseBuilder.Build(map, lastFlagPos.x, lastFlagPos.y, baseSizeX, baseSizeY, seed);
            }
            window.mapImage.Image = map;
            window.mapImage.Update();
        }
    }
}
