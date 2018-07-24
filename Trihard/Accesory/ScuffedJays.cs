using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Trihard.Accesory
{
    public class ScuffedJays : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scuffed Jays");
            Tooltip.SetDefault("N");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 10;
            item.rare = 8;
            item.accessory = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LavaWaders);
            recipe.AddIngredient(mod.ItemType("Afro"));
            recipe.AddIngredient(mod.ItemType("Watermelon"));
            recipe.AddIngredient(ItemID.FrostsparkBoots);
            recipe.AddTile(TileID.Anvils); 
            recipe.SetResult(this);
            recipe.AddRecipe();
            item.value = Item.buyPrice(10, 0, 0, 0);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {

            player.noFallDmg = true;
            player.canRocket = true;
            player.rocketTime = 200;
            player.rocketBoots = 1;
            player.rocketTimeMax = 200;
            player.moveSpeed += 200f;
            player.runAcceleration = 100;
            player.maxRunSpeed = 500;
            player.fireWalk = true;
            player.waterWalk = true;

        }
    }
}