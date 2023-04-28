﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KagMapGenerator
{
    public class Data
    {
        public static readonly Dictionary<string, Color> colors = new Dictionary<string, Color>
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
    }
}
