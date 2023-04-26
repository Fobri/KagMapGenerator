using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KagMapGenerator
{   
    internal class MapImageGenerator
    {
        FastNoiseLite noiseGenerator = new FastNoiseLite();

        static readonly Dictionary<string, Color> colors = new Dictionary<string, Color>
        {
            { "Sky", Color.FromArgb(165, 189, 200) },
            { "Dirt", Color.FromArgb(132, 71, 21) },
            { "Dirt Background", Color.FromArgb(59, 20, 6) },
            { "Stone", Color.FromArgb(139, 104, 73) },
            { "Thick Stone", Color.FromArgb(66, 72, 75) },
            { "Gold", Color.FromArgb(254, 165, 61) },
            { "Bedrock", Color.FromArgb(45, 52, 45) },
            { "Sand", Color.FromArgb(236, 213, 144) },
            { "Water (Air)", Color.FromArgb(46, 129, 166) },
            { "Water (Dirt Background)", Color.FromArgb(51, 85, 102) },
            { "Grass", Color.FromArgb(100, 155, 13) },
            { "Tree", Color.FromArgb(13, 103, 34) },
            { "Bush", Color.FromArgb(91, 126, 24) },
            { "Grain", Color.FromArgb(162, 183, 22) },
            { "Flower", Color.FromArgb(255, 102, 255) },
            { "Shark", Color.FromArgb(44, 175, 222) },
            { "Fish", Color.FromArgb(121, 168, 163) },
            { "Bison", Color.FromArgb(183, 86, 70) },
            { "Chicken", Color.FromArgb(141, 38, 20) },
            { "Castle Block", Color.FromArgb(100, 113, 96) },
            { "Castle Background", Color.FromArgb(49, 52, 18) },
            { "Mossy Castle Block", Color.FromArgb(100, 143, 96) },
            { "Mossy Castle Background", Color.FromArgb(49, 82, 18) },
            { "Wood Block", Color.FromArgb(196, 135, 21) },
            { "Wood Background", Color.FromArgb(85, 42, 17) },
            { "Ladder", Color.FromArgb(66, 36, 11) },
            { "Platform", Color.FromArgb(255, 146, 57) },
            { "Wooden Door", Color.FromArgb(148, 148, 148) },
            { "Stone Door", Color.FromArgb(160, 160, 160) },
            { "Trap Block", Color.FromArgb(100, 100, 100) },
            { "Spike", Color.FromArgb(180, 42, 17) },
            { "Spike (on Dirt)", Color.FromArgb(180, 97, 17) },
            { "Spike (on Castle)", Color.FromArgb(180, 42, 94) },
            { "Spike (on Wood)", Color.FromArgb(200, 42, 94) },
            {"Hall", Color.FromArgb(211, 249, 193)},
            {"Storage", Color.FromArgb(217, 255, 239)},
            {"Barracks", Color.FromArgb(217, 218, 255)},
            {"Factory", Color.FromArgb(255, 217, 237)},
            {"Tunnel", Color.FromArgb(243, 217, 254)},
            {"Kitchen", Color.FromArgb(255, 217, 217)},
            {"Nursery", Color.FromArgb(217, 255, 223)},
            {"Research", Color.FromArgb(225, 225, 225)},
            {"Workbench", Color.FromArgb(0, 255, 0)},
            {"Quarters", Color.FromArgb(240, 190, 255)},
            {"Campfire", Color.FromArgb(251, 226, 139)},
            {"Catapult", Color.FromArgb(103, 229, 165)},
            {"Ballista", Color.FromArgb(100, 210, 160)},
            {"Mounted Bow", Color.FromArgb(56, 232, 184)},
            {"Raft", Color.FromArgb(70, 110, 160)},
            {"Dinghy", Color.FromArgb(201, 158, 246)},
            {"Long Boat", Color.FromArgb(0, 51, 255)},
            {"War Boat", Color.FromArgb(50, 140, 255)},
            {"Air Ship", Color.FromArgb(255, 175, 0)},
            {"Bomber", Color.FromArgb(255, 190, 0)},
            {"Saw", Color.FromArgb(202, 164, 130)},
            {"Drill", Color.FromArgb(210, 120, 0)},
            {"Trampoline", Color.FromArgb(187, 59, 253)},
            {"Lantern", Color.FromArgb(241, 231, 177)},
            {"Crate", Color.FromArgb(102, 0, 0)},
            {"Bucket", Color.FromArgb(225, 220, 120)},
            {"Log", Color.FromArgb(160, 140, 40)},
            {"Boulder", Color.FromArgb(161, 149, 133)},
            {"Arrows", Color.FromArgb(200, 210, 70)},
            {"Fire Arrows", Color.FromArgb(230, 210, 70)},
            {"Water Arrows", Color.FromArgb(200, 160, 10)},
            {"Bomb Arrows", Color.FromArgb(200, 180, 10)},
            {"Bolts", Color.FromArgb(230, 230, 170)},
            {"Bombs", Color.FromArgb(251, 241, 87)},
            {"Water Bombs", Color.FromArgb(210, 200, 120)},
            {"Satchel", Color.FromArgb(170, 100, 0)},
            {"Mini Keg", Color.FromArgb(160, 30, 30)},
            {"Keg", Color.FromArgb(220, 60, 60)},
            {"Wood Stack", Color.FromArgb(200, 190, 140)},
            {"Stone Stack", Color.FromArgb(190, 190, 175)},
            {"Gold Stack", Color.FromArgb(255, 240, 160)},
            {"Heart", Color.FromArgb(255, 40, 80)},
            {"Burger", Color.FromArgb(205, 142, 75)},
            {"Mine (no team)", Color.FromArgb(215, 75, 255)},
            { "Blue Spawn (Main)", Color.FromArgb(0, 255, 255) },
            { "Blue Spawn", Color.FromArgb(0, 200, 200) },
            { "Blue Door (Wood)", Color.FromArgb(26, 78, 131) },
            { "Blue Door (Stone)", Color.FromArgb(80, 90, 160) },
            { "Blue Trap Block", Color.FromArgb(56, 76, 142) },
            { "Blue Tunnel", Color.FromArgb(220, 217, 254) },
            { "Red Spawn (Main)", Color.FromArgb(255, 0, 0) },
            { "Red Spawn", Color.FromArgb(200, 0, 0) },
            { "Red Door (wood)", Color.FromArgb(148, 27, 27) },
            { "Red Door (Stone)", Color.FromArgb(160, 90, 80) },
            { "Red Trap Block", Color.FromArgb(142, 56, 68) },
            { "Red Tunnel", Color.FromArgb(243, 217, 220) },
            { "Blue Trading Post", Color.FromArgb(136, 136, 255) },
            { "Red Trading Post", Color.FromArgb(255, 136, 136) },
            { "Green Spawn (main)", Color.FromArgb(157, 202, 34) },
            { "Green Spawn", Color.FromArgb(100, 155, 13) },
            { "Purple Spawn (main)", Color.FromArgb(211, 121, 224) },
            { "Purple Spawn", Color.FromArgb(158, 58, 204) },
            { "Orange Spawn (main)", Color.FromArgb(205, 97, 32) },
            { "Orange Spawn", Color.FromArgb(132, 71, 21) },
            { "Aqua Spawn (main)", Color.FromArgb(46, 229, 162) },
            { "Aqua Spawn", Color.FromArgb(79, 155, 127) },
            { "Teal Spawn (main)", Color.FromArgb(95, 132, 236) },
            { "Teal Spawn", Color.FromArgb(65, 73, 240) },
            { "Gray Spawn (main)", Color.FromArgb(196, 207, 161) },
            { "Gray Spawn", Color.FromArgb(151, 167, 146) },
            { "redbarrier", Color.FromArgb(228,55,113) },
            { "redflag", Color.FromArgb(200,0,0) },
            { "blueflag", Color.FromArgb(0,200,200) },
            { "goldquarry", Color.FromArgb(255,151,85) },
            { "ballista", Color.FromArgb(54,188,117) },
            { "catapult", Color.FromArgb(136,55,190) },
            { "midshop3", Color.FromArgb(85,74,209) },
            { "midshop4", Color.FromArgb(85,0,209) },
            { "nomidshop", Color.FromArgb(85,74,74) },

        };

        Random rng;

        public MapImageGenerator()
        {
            noiseGenerator.SetFractalType(FastNoiseLite.FractalType.FBm);
        }

        int xSize;
        int ySize;

        public Bitmap GetMapImage(int xSize, int ySize, float freq, float steepness, int seed, bool caveMap, bool islandMap, int grassChance, int stoneChance, int redzone, int flagCount, int flagInterval, int bedrockDepth, float bedrockRoughness, int treeAmount, int treeInterval, int tentEdgeDst, int midShopCount)
        {
            this.xSize = xSize;
            this.ySize = ySize;
            noiseGenerator.SetFrequency(freq);
            rng = new Random(seed);
            Bitmap result = new Bitmap(xSize, ySize);
            result.SetResolution(xSize, ySize);

            int xOffset = rng.Next(99999);
            int yOffset = rng.Next(99999);

            int midShopInterval = (midShopCount == 0) ? 999999 : (xSize/2 - redzone * ((midShopCount == 1) ? 0 : 1)) / midShopCount * ((midShopCount > 1) ? 2 : 1) - 1;

            for(int y = 0; y < ySize; y++)
            {
                int ySamplePos = y + yOffset;
                for(int x = 0; x < xSize / 2; x++) {
                    int xSamplePos = x + xOffset;
                    float bedrockLevel = GetBedrockLevel(xSamplePos);
                    float dirtLevel = GetBedrockLevel(xSamplePos * steepness + 654) - 10;
                    var dstFromDirt = 1 - Math.Max(Math.Abs(dirtLevel - y) * 0.1f, 0);
                    float val = dstFromDirt * (caveMap ? dstFromDirt : 1f) + dstFromDirt * 1 - SampleNoise(xSamplePos, ySamplePos) * 5 + (SampleNoise(xSamplePos + 231, ySamplePos + 53224) * y * 0.01f);
                    Color col;
                    //if (y > bedrockLevel) col = colors["Bedrock"];
                    if (val > 0 || (y > dirtLevel && !islandMap)) col = colors["Dirt"];
                    else col = colors["Sky"];
                    AddBlock(col, x, y, result);
                }
            }
            bool addedTents = false;
            int flagsPlaced = 0;
            int treesPlaced = 0;
            int2 lastIntervalPos = new int2(-999, -999);
            int2 lastTreePos = new int2(-999, -999);
            for (int x = 0; x < xSize / 2; x++)
            {
                bool foundSky = false;
                bool foundFirstDirt = false;
                int xSamplePos = x + xOffset;
                for (int y = 0; y < ySize; y++)
                {
                    int ySamplePos = y + yOffset;
                    Color pixel = result.GetPixel(x, y);
                    if(pixel == colors["Sky"])
                    {
                        foundSky = true;
                    }
                    else if (colors["Dirt"] == pixel)
                    {
                        if (foundSky && !foundFirstDirt)
                        {
                            if (y == 0) continue;
                            foundFirstDirt = true;
                            if (!addedTents && x > tentEdgeDst && int2.distance(lastIntervalPos, new int2(x, y)) > flagInterval && TryAddTents(x, y, result))
                            {
                                lastIntervalPos = new int2(x, y);
                                addedTents = true;
                                continue;
                            }
                            if (flagsPlaced < flagCount && x > 30 && x < redzone && int2.distance(lastIntervalPos, new int2(x, y)) > flagInterval && TryAddFlags(x, y, result))
                            {
                                lastIntervalPos = new int2(x, y);
                                flagsPlaced++;
                                continue;
                            }
                            if (rng.Next(0, 100) < grassChance)
                            {
                                if (result.GetPixel(x, y - 1) == colors["Bedrock"] || int2.distance(new int2(x,y), lastIntervalPos) < treeInterval) continue;
                                Color col;
                                if (x > 15 && int2.distance(lastTreePos, new int2(x, y)) > treeInterval && treesPlaced < treeAmount)
                                {
                                    treesPlaced++;
                                    lastTreePos = new int2(x, y);
                                    col = colors["Tree"];
                                }else
                                    col = colors["Grass"];
                                AddBlock(col, x, y - 1, result);
                            }

                            if (x > redzone && x % midShopInterval == 0)
                            {
                                var col = (xSize % 2 == 0) ? colors["midshop4"] : colors["midshop3"];
                                AddBlock(col, x, y - 1, result, midShopCount > 1);
                            }
                        }
                        noiseGenerator.SetFrequency(freq * 10);
                        bool addedBedrock = false;
                        if (!HasBlockInRadius(x, y, result, colors["Sky"], bedrockDepth))
                        {
                            addedBedrock = true;
                            AddBlock(colors["Bedrock"], x, y, result);
                        }
                        else if (!HasBlockInRadius(x, y, result, colors["Sky"], bedrockDepth - 2) && noiseGenerator.GetNoise(x * bedrockRoughness,y * bedrockRoughness) > 0f)
                        {
                            addedBedrock = true;
                            AddBlock(colors["Bedrock"], x, y, result);
                        }
                        if (!addedBedrock)
                        {
                            noiseGenerator.SetFrequency(freq);
                            if(noiseGenerator.GetNoise(x+5321, x+9112) > 0.4f)
                            {
                                noiseGenerator.SetFrequency(freq * 10f);
                                float val = noiseGenerator.GetNoise(x + 123, y + 4278) + 1;
                                if (val * 50 < stoneChance - 20)
                                {
                                    AddBlock(colors["Thick Stone"], x, y, result);
                                }else if (val * 50 < stoneChance)
                                {
                                    AddBlock(colors["Stone"], x, y, result);
                                }
                            }
                        }
                    }
                    if(pixel == colors["Sky"])
                    {
                        if (HasBlockInRadius(x, y, result, colors["Dirt"], 1))
                        {

                            AddBlock(colors["Dirt Background"], x, y, result);
                            noiseGenerator.SetFrequency(freq * 10f);
                            if (noiseGenerator.GetNoise(x + 5363, x + 2534) > 0f)
                            {
                                int radius = rng.Next(3, 5);
                                for(int s = -radius; s < radius; s++)
                                {
                                    for (int j = -radius; j < radius; j++)
                                    {
                                        if (!IsValidCoord(x + s, y + j)) continue;
                                        if (!HasBlockInRadius(x + s, y + j, result, colors["Dirt Background"], 1) || result.GetPixel(x + s, y + j) != colors["Sky"]) continue;
                                        noiseGenerator.SetFrequency(freq * 10f);
                                        if (noiseGenerator.GetNoise(x + 1234 + s, y + 7522 + j) > 0f)
                                        {
                                            AddBlock(colors["Dirt Background"], x + s, y + j, result);
                                        }
                                    }
                                }
                            }
                            
                        }
                    }

                }
            }
            AddRedzone(redzone, result);
            if(midShopCount == 0)
            {
                AddNoMidshop(redzone, result);
            }

            return result;
        }

        void AddBlock(Color col, int x, int y, Bitmap result, bool mirror = true)
        {
            if (x < 0 || y < 0 || x >= xSize-1 || y >= xSize-1) return;
            result.SetPixel(x, y, col);
            if(mirror)
                result.SetPixel(xSize - x - 1, y, col);
        }

        float GetBedrockLevel(float x)
        {
            float baseCurve = Sin(x * 0.1f + Sin(x * 0.1f)) * 10f * Sin(0.001f);
            //baseCurve += (float)Math.Sin(x * rng.NextDouble());
            return (baseCurve + ySize / 1.5f);
        }

        void AddRedzone(int x, Bitmap map)
        {
            AddAnywhereOnYAxis(x, map, colors["redbarrier"]);
        }
        void AddNoMidshop(int x, Bitmap map)
        {
            AddAnywhereOnYAxis(x, map, colors["nomidshop"], false);
        }
        void AddAnywhereOnYAxis(int x, Bitmap map, Color col, bool mirror = true)
        {
            for (int y = 0; y < ySize; y++)
            {
                if (map.GetPixel(x, y) == colors["Sky"])
                {
                    AddBlock(col, x, y, map, mirror);
                    return;
                }
            }
            for (int y = 0; y < ySize; y++)
            {
                if (map.GetPixel(x, y) == colors["Bedrock"])
                {
                    AddBlock(col, x, y, map, mirror);
                    return;
                }
            }
        }

        bool TryAddTents(int x, int y, Bitmap map)
        {
            if (!IsValidCoord(x, y)) return false;
            var dirt = colors["Dirt"];
            var sky = colors["Sky"];
            if(map.GetPixel(x+1, y) == dirt
            && map.GetPixel(x+2, y) == dirt
            && map.GetPixel(x, y - 1) != dirt
            && map.GetPixel(x + 1, y - 1) != dirt
            && map.GetPixel(x + 2, y - 1) != dirt)
            {
                AddBlock(colors["Blue Spawn (Main)"], x + 1, y - 1, map, false);
                AddBlock(colors["Red Spawn (Main)"], xSize - x - 2, y - 1, map, false);
                return true;
            }
            return false;
        }

        bool TryAddFlags(int x, int y, Bitmap map)
        {
            if (!IsValidCoord(x, y)) return false;
            var dirt = colors["Dirt"];
            if (map.GetPixel(x + 1, y) == dirt
            && map.GetPixel(x + 2, y) == dirt
            && map.GetPixel(x, y - 1) != dirt
            && map.GetPixel(x + 1, y - 1) != dirt
            && map.GetPixel(x + 2, y - 1) != dirt)
            {
                AddBlock(colors["blueflag"], x +1, y - 2, map, false);
                AddBlock(colors["redflag"], xSize - x - 2, y - 2, map, false);

                AddBlock(colors["Bedrock"], x + 1, y, map);
                AddBlock(colors["Bedrock"], x, y, map);
                AddBlock(colors["Bedrock"], x + 2, y, map);
                return true;
            }
            return false;
        }

        bool HasBlockInRadius(int xPos, int yPos, Bitmap map, Color block, int radius)
        {
            for(int x = -radius; x < radius; x++)
            {
                for(int  y = -radius; y < radius; y++)
                {
                    if(x == 0 && y == 0) continue;
                    if (!IsValidCoord(x + xPos, y + yPos)) continue;
                    if (map.GetPixel(x+xPos, y+yPos) == block)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        bool IsValidCoord(int x, int y)
        {
            return x >= 0 && y >= 0 && x < xSize && y < ySize;
        }

        float SampleNoise(int x, int y)
        {
            return noiseGenerator.GetNoise(x, y);
        }

        public static float Sin(float x)
        {
            float frequency = 1f;
            float amplitude = 1f;
            float noiseHeight = 0f;
            int octaves = 4;
            float lacunarity = 0.5f;
            float persistence = 0.5f;

            for (int i = 0; i < octaves; i++)
            {
                float noiseValue = ((float)Math.Sin(x * frequency) + 1) * 0.5f * amplitude;
                noiseHeight += noiseValue;
                frequency *= lacunarity;
                amplitude *= persistence;
            }

            return noiseHeight;
        }
    }

    struct int2
    {
        int x;
        int y;

        public int2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static float distance(int2 a, int2 b)
        {
            return (float)Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }
    }
}
