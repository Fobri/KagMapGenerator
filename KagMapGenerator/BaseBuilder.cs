using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KagMapGenerator
{
    public enum DIR_FLAG { LEFT = 1, RIGHT = 2, UP = 4, DOWN = 8 }
    internal class BaseBuilder
    {
        const int LEFT = 1;
        const int RIGHT = 2;
        const int UP = 4;
        const int DOWN = 8;
        Dictionary<Color, Color> doorColorConversion = new Dictionary<Color, Color>()
        {
            { Color.FromArgb(128, 208, 64, 208), Color.FromArgb(129, 208, 64, 208) },
            { Color.FromArgb(128, 208, 32, 208), Color.FromArgb(129, 208, 32, 208) }
        };
        static readonly List<BuildingBlock> buildingBlocks = new List<BuildingBlock>() {
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) }
            }, 0, 5, "solid"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) }
            }, DOWN, -1, "flag_upper"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208), Color.FromArgb(128,208,64,208) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208), Color.FromArgb(128,208,64,208) }
            }, (RIGHT | LEFT | DOWN), -1, "flag_lower"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,64,208), Color.FromArgb(128,208,64,208), Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(128,208,64,208) },
                { Color.FromArgb(128,208,32,208), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(128,208,64,208) }
            }, RIGHT | LEFT | DOWN | UP, 3, "basic1"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(143,208,80,208), Color.FromArgb(143,208,80,208), Color.FromArgb(143,208,80,208), Color.FromArgb(143,208,80,208), Color.FromArgb(143,208,80,208), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(128,208,64,208) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208) }
            }, RIGHT | LEFT | DOWN | UP, 3, "basic2"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,64,208), Color.FromArgb(128,208,64,208), Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,32,208), Color.FromArgb(128,208,32,208), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(128,208,64,208) }
            }, RIGHT | LEFT | DOWN | UP, 3, "basic3"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208) }
            }, RIGHT | LEFT | DOWN, 3, "basic4"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,32,208), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) }
            }, RIGHT | UP, 3, "basic5"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,64,208), Color.FromArgb(128,208,64,208), Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,32,208), Color.FromArgb(128,208,32,208), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(255,100,113,96) }
            }, DOWN | UP, 3, "basic6"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,64,208), Color.FromArgb(128,208,64,208), Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,32,208), Color.FromArgb(128,208,32,208), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,165,189,200), Color.FromArgb(255,165,189,200), Color.FromArgb(255,100,113,96) }
            }, DOWN | UP, 3, "basic7"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208) },
                { Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208) }
            }, LEFT | RIGHT, 3, "basic8"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(128,208,64,208) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(128,208,64,208) }
            }, RIGHT | DOWN, 3, "basic9"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(128,208,64,208), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) }
            }, LEFT | DOWN, 3, "basic10"),
            new BuildingBlock(new Color[,]
            {
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,49,52,18), Color.FromArgb(128,208,64,208), Color.FromArgb(255,100,113,96), Color.FromArgb(128,208,64,208), Color.FromArgb(255,49,52,18), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) },
                { Color.FromArgb(255,100,113,96), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,49,52,18), Color.FromArgb(255,85,42,17), Color.FromArgb(255,85,42,17), Color.FromArgb(255,100,113,96) }
            }, UP | DOWN, 3, "basic11")
        };
        public Cell[,] entropyField;
        Random rng;
        HashSet<int2> wfcSet = new HashSet<int2>();
        int sizeX;
        int sizeY;
        int maxBlockWeight;
        public void Build(Bitmap map, int flagPosX, int flagPosY, int baseSizeX, int baseSizeY, int seed)
        {
            rng = new Random(seed);
            entropyField = new Cell[baseSizeX, baseSizeY];
            sizeX = baseSizeX;
            sizeY = baseSizeY;
            for(int i = 0; i < buildingBlocks.Count; i++)
            {
                maxBlockWeight = Math.Max(maxBlockWeight, buildingBlocks[i].weight);
            }
            for (int x = 0; x < baseSizeX; x++)
            {
                for (int y = 0; y < baseSizeY; y++)
                {
                    int sampleX = flagPosX - (baseSizeX * 7 / 2) + x * 7 + 4;
                    int sampleY = flagPosY - (baseSizeY * 4 / 2) + y * 4 - 2;
                    if (sampleX < 0 || sampleY < 0 || sampleX >= map.Width - 1 || sampleY >= map.Height - 1) continue;
                    var pixel = map.GetPixel(sampleX, sampleY);
                    /*if (pixel == Data.colors["Sky"] || pixel == Data.colors["Grass"] || pixel == Data.colors["Tree"] || pixel == Data.colors["Stone"] || pixel == Data.colors["Thick Stone"])
                    {
                        entropyField[x, y].blockIndex = -1;
                        entropyField[x, y].directionMask = 0; // no constraints yet
                    }*/
                    if (pixel == Data.colors["blueflag"])
                    {

                        entropyField[x, y-1].blockIndex = buildingBlocks.FindIndex(v => v.name == "flag_upper");
                        entropyField[x, y-1].directionMask = byte.MaxValue;
                        Propagate(buildingBlocks.Find(v => v.name == "flag_upper"), new int2(x, y - 1));
                        entropyField[x, y].blockIndex = buildingBlocks.FindIndex(v => v.name == "flag_lower");
                        Propagate(buildingBlocks.Find(v => v.name == "flag_lower"), new int2(x, y));
                        entropyField[x, y].directionMask = byte.MaxValue;

                        wfcSet.Add(new int2(x, y));
                        wfcSet.Add(new int2(x, y-1));
                    }
                    else
                    {
                        //map.SetPixel(sampleX, sampleY, Data.colors["Bison"]);
                        entropyField[x, y].blockIndex = -1;
                    }
                }
            }
            WFCRecursive();
            for (int x = 0; x < baseSizeX; x++)
            {
                for (int y = 0; y < baseSizeY; y++)
                {
                    int blockIdx = entropyField[x, y].blockIndex;
                    //Debug.Print(entropyField[x, y].directionMask.ToString());
                    if (blockIdx == -1) continue;

                    var data = buildingBlocks[blockIdx].data;

                    int blockCenterX = flagPosX - (baseSizeX * 7 / 2) + x * 7 + 4;
                    int blockCenterY = flagPosY - (baseSizeY * 4 / 2) + y * 4 - 2;
                    for (int mapX = 0; mapX < 7; mapX++)
                    {
                        for (int mapY = 0; mapY < 4; mapY++)
                        {
                            int sampleX = blockCenterX - 3 + mapX;
                            int sampleY = blockCenterY - 2 + mapY;
                            if (sampleX < 0 || sampleY < 0 || sampleX > map.Width - 1 || sampleY > map.Height - 1) continue;
                            var pixel = map.GetPixel(sampleX, sampleY);
                            if (pixel == Data.colors["blueflag"] || pixel == Data.colors["Dirt"] || pixel == Data.colors["Stone"] ||
                                pixel == Data.colors["Thick Stone"] || pixel == Data.colors["Blue Spawn (Main)"] || pixel == Data.colors["Bedrock"]) continue;

                            map.SetPixel(sampleX, sampleY, data[mapY, mapX]);
                            var col = doorColorConversion.ContainsKey(data[mapY, mapX]) ? doorColorConversion[data[mapY, mapX]] : data[mapY, mapX];
                            map.SetPixel(map.Width - sampleX - 1, sampleY, col);
                        }
                    }
                }
            }
        }
        void WFCRecursive()
        {
            int minVal = -1;
            int2 pos = new int2(-99, -99);
            foreach(var v in wfcSet)
            {
                var setBits = CountSetBits(entropyField[v.x, v.y].directionMask);
                if (setBits > minVal)
                {
                    minVal = setBits;
                    pos = new int2(v.x, v.y);
                }
            }
            if(pos.x == -99)
            {
                //Done
                return;
            }
            wfcSet.Remove(pos);
            if (entropyField[pos.x, pos.y].blockIndex == -1)
            {
                entropyField[pos.x, pos.y].blockIndex = CollapseCell(pos.x, pos.y);
            }
            Propagate(buildingBlocks[entropyField[pos.x, pos.y].blockIndex], pos);
            WFCRecursive();
        }

        int CollapseCell(int x, int y)
        {
            int directionMask = entropyField[x, y].directionMask;
            entropyField[x, y].directionMask = byte.MaxValue;
            var possibleBlocks = buildingBlocks.FindAll(s => (s.directionFlags & directionMask) == directionMask);
            if (possibleBlocks.Count == 0) return 0;
            //Get max direction mask hit count
            int maxDirHitCount = 0;
            for (int i = 0; i < possibleBlocks.Count; i++) { 

                int hitCount = MaskHitCount((byte)possibleBlocks[i].directionFlags, (byte)directionMask);
                if (possibleBlocks[i].weight > 0)
                    maxDirHitCount = Math.Max(hitCount, maxDirHitCount);
            }
            //Get all blocks which satisfy direction mask best
            var bestMaskHitCounts = possibleBlocks.Where(s => MaskHitCount((byte)s.directionFlags, (byte)directionMask) == maxDirHitCount && s.weight > 0);
            if(bestMaskHitCounts.Count() == 1)
            {
                return buildingBlocks.IndexOf(bestMaskHitCounts.First());
            }
            //todo randomness from weights
            return buildingBlocks.IndexOf(bestMaskHitCounts.ElementAt(rng.Next(0,bestMaskHitCounts.Count())));
        }

        public void Propagate(BuildingBlock block, int2 pos)
        {
            if (pos.x > 0 && (block.directionFlags & LEFT) != 0)
            {
                if (entropyField[pos.x - 1, pos.y].directionMask != byte.MaxValue)
                {
                    entropyField[pos.x - 1, pos.y].directionMask |= RIGHT;
                    wfcSet.Add(new int2(pos.x-1, pos.y));
                }
            }
            if (pos.x < entropyField.GetLength(0) - 1 && (block.directionFlags & RIGHT) != 0)
            {
                if (entropyField[pos.x + 1, pos.y].directionMask != byte.MaxValue)
                {
                    entropyField[pos.x + 1, pos.y].directionMask |= LEFT;
                    wfcSet.Add(new int2(pos.x+1, pos.y));
                }
            }
            if (pos.y > 0 && (block.directionFlags & UP) != 0)
            {
                if (entropyField[pos.x, pos.y - 1].directionMask != byte.MaxValue)
                {
                    entropyField[pos.x, pos.y - 1].directionMask |= DOWN;
                    wfcSet.Add(new int2(pos.x, pos.y-1));
                }
            }
            if (pos.y < entropyField.GetLength(1) - 1 && (block.directionFlags & DOWN) != 0)
            {
                if (entropyField[pos.x, pos.y + 1].directionMask != byte.MaxValue)
                {
                    entropyField[pos.x, pos.y + 1].directionMask |= UP;
                    wfcSet.Add(new int2(pos.x, pos.y+1));
                }
            }
        }
        public static int CountSetBits(int n)
        {
            int count = 0;
            for(int i = 0; i < 8; i++)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
        public static int MaskHitCount(byte a, byte b)
        {
            var testa = a;
            var testb = b;
            int count = 0;
            for(int i = 0; i < 8; i++)
            {
                if(((a & 1) & (b & 1)) == 1)
                {
                    count++;
                }
                a >>= 1; b >>= 1;
            }
            return count;
        }
    }
    public class BuildingBlock : IComparable
    {
        public Color[,] data;
        public int directionFlags;
        public int weight;
        public string name;

        public BuildingBlock(Color[,] data, int directionFlags, int weight, string name)
        {
            this.data = data;
            this.directionFlags = directionFlags;
            this.weight = weight;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            if(obj == this) return 0;
            if(obj is BuildingBlock)
            {
                var comp = obj as BuildingBlock;
                if(this.weight < comp.weight)
                {
                    return -1;
                }else if(this.weight == comp.weight)
                {
                    return 0;
                }
                return 1;
            }
            return 0;
        }
    }
    public struct Cell
    {
        public int blockIndex;
        public byte directionMask;

        public Cell(int blockIndex, byte directionMask)
        {
            this.blockIndex = blockIndex;
            this.directionMask = directionMask;
        }
    }
}
