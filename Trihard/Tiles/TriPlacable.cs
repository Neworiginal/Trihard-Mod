﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Trihard.Tiles
{
    public class TriPlacable : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("Triblock");   //put your CustomBlock name
            AddMapEntry(new Color(200, 200, 200));
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
            r = 0.5f;
            g = 0.5f;
            b = 0.5f;
        }
    }
}