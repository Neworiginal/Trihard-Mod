using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Trihard.Weapon
{
    public class TriBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a modded bullet ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 1000;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("TriBulletProjectile");   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 16f;                  //The speed of the projectile
            item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
        }

        // Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
        public override void OnConsumeAmmo(Player player)
        {
            if (Main.rand.NextBool(5))
            {
                player.AddBuff(BuffID.Wrath, 300);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(ItemID.LunarBar, 600);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}