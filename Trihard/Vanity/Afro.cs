using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Trihard.Vanity   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{   [AutoloadHead]
    public class Afro : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Afro");
            Tooltip.SetDefault("Niger");
        }

        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;   //The size in height of the sprite in pixels.
            item.rare = 11;    //The color the title of your item when hovering over it ingame 
            item.vanity = true; //this defines if this item is vanity or not.
            item.value = Item.buyPrice(20, 0, 0, 0);
        }

        public override bool DrawHead()
        {
            return true;     //this make so the player head does not disappear when the vanity mask is equipped.  return false if you want to not show the player head.
        }
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = drawAltHair = false;  //this make so the player hair does not show when the vanity mask is equipped.  add true if you want to show the player hair.
        }
    }
}