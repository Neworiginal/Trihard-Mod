using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Trihard;

namespace Trihard.Potion
{
    public class WatermelonBuff : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Watermelon Buff");
            Description.SetDefault("You are now a nigger");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
            canBeCleared = true;

        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 250;
            player.invis = true;
            player.statDefense += 20;
            player.statLifeMax2 += 50;
        }
    }
}
