using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace KagMapGenerator
{   
    internal class MapImageGenerator
    {
        FastNoiseLite noiseGenerator = new FastNoiseLite();

        Random rng;

        public MapImageGenerator()
        {
            noiseGenerator.SetFractalType(FastNoiseLite.FractalType.FBm);
        }

        int xSize;
        int ySize;
        int groundLevel;

        public Bitmap GetMapImage(int xSize, int ySize, float freq, float steepness, int seed, bool caveMap, bool islandMap, int grassChance, int stoneChance, int redzone, int flagCount, int flagInterval, int bedrockDepth, float bedrockRoughness, int treeAmount, int treeInterval, int tentEdgeDst, int midShopCount, int groundLevel, float flatness, out int2 lastFlagPos)
        {
            this.xSize = xSize;
            this.ySize = ySize;
            this.groundLevel = groundLevel;
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
                    var dstFromDirt = 1 - Math.Max(Math.Abs(dirtLevel - y) * 0.1f, 0) * flatness;
                    float val = dstFromDirt * (caveMap ? dstFromDirt : 1f) + dstFromDirt * 1 - SampleNoise(xSamplePos, ySamplePos) * 5 + (SampleNoise(xSamplePos + 231, ySamplePos + 53224) * y * 0.01f);
                    Color col;
                    //if (y > bedrockLevel) col = Data.colors["Bedrock"];
                    if (val > 0 || (y > dirtLevel && !islandMap)) col = Data.colors["Dirt"];
                    else col = Data.colors["Sky"];
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
                    if(pixel == Data.colors["Sky"])
                    {
                        foundSky = true;
                    }
                    else if (Data.colors["Dirt"] == pixel)
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
                                if (result.GetPixel(x, y - 1) == Data.colors["Bedrock"] || int2.distance(new int2(x,y), lastIntervalPos) < treeInterval) continue;
                                Color col;
                                if (x > 15 && int2.distance(lastTreePos, new int2(x, y)) > treeInterval && treesPlaced < treeAmount)
                                {
                                    treesPlaced++;
                                    lastTreePos = new int2(x, y);
                                    col = Data.colors["Tree"];
                                }else
                                    col = Data.colors["Grass"];
                                AddBlock(col, x, y - 1, result);
                            }

                            if (x > redzone && x % midShopInterval == 0)
                            {
                                var col = (xSize % 2 == 0) ? Data.colors["midshop4"] : Data.colors["midshop3"];
                                AddBlock(col, x, y - 1, result, midShopCount > 1);
                            }
                        }
                        noiseGenerator.SetFrequency(freq * 10);
                        bool addedBedrock = false;
                        if (!HasBlockInRadius(x, y, result, Data.colors["Sky"], bedrockDepth))
                        {
                            addedBedrock = true;
                            AddBlock(Data.colors["Bedrock"], x, y, result);
                        }
                        else if (!HasBlockInRadius(x, y, result, Data.colors["Sky"], bedrockDepth - 2) && SampleNoise(x * bedrockRoughness,y * bedrockRoughness) > 0f)
                        {
                            addedBedrock = true;
                            AddBlock(Data.colors["Bedrock"], x, y, result);
                        }
                        if (!addedBedrock)
                        {
                            noiseGenerator.SetFrequency(freq * 4);
                            if(SampleNoise(x+5321, y+9112) > 0.4f)
                            {
                                noiseGenerator.SetFrequency(freq * 10f);
                                float val = SampleNoise(x + 123, y + 4278) + 1;
                                if (val * 50 < stoneChance - 20)
                                {
                                    AddBlock(Data.colors["Thick Stone"], x, y, result);
                                }else if (val * 50 < stoneChance)
                                {
                                    AddBlock(Data.colors["Stone"], x, y, result);
                                }
                            }
                        }
                    }
                    if(pixel == Data.colors["Sky"])
                    {
                        if (HasBlockInRadius(x, y, result, Data.colors["Dirt"], 1))
                        {

                            AddBlock(Data.colors["Dirt Background"], x, y, result);
                            noiseGenerator.SetFrequency(freq * 10f);
                            if (SampleNoise(x + 5363, y + 2534) > 0f)
                            {
                                int radius = rng.Next(3, 5);
                                for(int s = -radius; s < radius; s++)
                                {
                                    for (int j = -radius; j < radius; j++)
                                    {
                                        if (!IsValidCoord(x + s, y + j)) continue;
                                        if (!HasBlockInRadius(x + s, y + j, result, Data.colors["Dirt Background"], 1) || result.GetPixel(x + s, y + j) != Data.colors["Sky"]) continue;
                                        noiseGenerator.SetFrequency(freq * 10f);
                                        if (SampleNoise(x + 1234 + s, y + 7522 + j) > 0f)
                                        {
                                            AddBlock(Data.colors["Dirt Background"], x + s, y + j, result);
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
            lastFlagPos = lastIntervalPos;
            return result;
        }

        void AddBlock(Color col, int x, int y, Bitmap result, bool mirror = true)
        {
            if (x < 0 || y < 0 || x > xSize-1 || y > ySize-1) return;
            result.SetPixel(x, y, col);
            if(mirror)
                result.SetPixel(xSize - x - 1, y, col);
        }

        float GetBedrockLevel(float x)
        {
            float baseCurve = Sin(x * 0.1f + Sin(x * 0.1f)) * 10f * Sin(0.001f);
            //baseCurve += (float)Math.Sin(x * rng.NextDouble());
            return (baseCurve + ySize / 1.5f) + groundLevel;
        }

        void AddRedzone(int x, Bitmap map)
        {
            AddAnywhereOnYAxis(x, map, Data.colors["redbarrier"]);
        }
        void AddNoMidshop(int x, Bitmap map)
        {
            AddAnywhereOnYAxis(x, map, Data.colors["nomidshop"], false);
        }
        void AddAnywhereOnYAxis(int x, Bitmap map, Color col, bool mirror = true)
        {
            for (int y = 0; y < ySize; y++)
            {
                if (map.GetPixel(x, y) == Data.colors["Sky"])
                {
                    AddBlock(col, x, y, map, mirror);
                    return;
                }
            }
            for (int y = 0; y < ySize; y++)
            {
                if (map.GetPixel(x, y) == Data.colors["Bedrock"])
                {
                    AddBlock(col, x, y, map, mirror);
                    return;
                }
            }
        }

        bool TryAddTents(int x, int y, Bitmap map)
        {
            if (!IsValidCoord(x, y)) return false;
            var dirt = Data.colors["Dirt"];
            var sky = Data.colors["Sky"];
            if(map.GetPixel(x+1, y) == dirt
            && map.GetPixel(x+2, y) == dirt
            && map.GetPixel(x, y - 1) != dirt
            && map.GetPixel(x + 1, y - 1) != dirt
            && map.GetPixel(x + 2, y - 1) != dirt)
            {
                AddBlock(Data.colors["Blue Spawn (Main)"], x + 1, y - 1, map, false);
                AddBlock(Data.colors["Red Spawn (Main)"], xSize - x - 2, y - 1, map, false);
                return true;
            }
            return false;
        }

        bool TryAddFlags(int x, int y, Bitmap map)
        {
            if (!IsValidCoord(x, y)) return false;
            var dirt = Data.colors["Dirt"];
            if (map.GetPixel(x + 1, y) == dirt
            && map.GetPixel(x + 2, y) == dirt
            && map.GetPixel(x, y - 1) != dirt
            && map.GetPixel(x + 1, y - 1) != dirt
            && map.GetPixel(x + 2, y - 1) != dirt)
            {
                AddBlock(Data.colors["blueflag"], x +1, y - 2, map, false);
                AddBlock(Data.colors["redflag"], xSize - x - 2, y - 2, map, false);

                AddBlock(Data.colors["Bedrock"], x + 1, y, map);
                AddBlock(Data.colors["Bedrock"], x, y, map);
                AddBlock(Data.colors["Bedrock"], x + 2, y, map);
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

        float SampleNoise(float x, float y)
        {
            y -= groundLevel;
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
        public int x;
        public int y;

        public int2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static float distance(int2 a, int2 b)
        {
            return (float)Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashcode = x * 397;
                hashcode ^= y;
                return hashcode;
            }
        }
    }
}
