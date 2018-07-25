using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Trihard.Weapon   //this is where is this file
{
    public class TerroistRPG : ModItem  //this is the class name
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terrorist RPG");
            Tooltip.SetDefault(";)");
        }
        public override void SetDefaults()
        {
            item.damage = 800;      //this is the damage of the item
            item.ranged = true;   //Whether the damage this item deals is considered ranged
            item.width = 20;
            item.useAmmo = AmmoID.Rocket;
            item.height = 20;
            item.shootSpeed = 0.1f;
            item.useTime = 4;        //How long it takes to use the item, in frames
            item.useAnimation = 29;    //How long it takes the animation to play for the item
            item.useStyle = 5;      //The animation that is played when the item is used
            item.knockBack = 5;  //this is the weapon knockback
            item.crit = 4;   //the weapon critical strike
            item.UseSound = SoundID.Item11;   //The type of sound to play when the item is used
            item.value = Item.buyPrice(30, 0, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 11;//The color to draw the item's name in
            item.shootSpeed = 16f; //this is the speed of the projectile that is created          
            item.autoReuse = true;  //true = autofire, add false if u don't want to autofire
            item.noMelee = true;  //Whether this item is allowed to deal damage with its sprite. Typically set to true for a ranged weapon, which would rely on its projectiles to deal damage, instead.
        }

    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }

        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 300);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("BloodstoneCore"), 100);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Phantoplasm"), 100);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("BloodOrb"), 75);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Seadragon"));//this is how to add an ingredient from Terraria,  so for craftin this item u need 1 Dirt Block
            recipe.AddTile(TileID.Anvils);   //this is where to craft the item ,    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);  //there you can set the output and the quantity of the item crafting
            recipe.AddRecipe();
        }
        public override Vector2? HoldoutOffset()
        {                                     //this make the player hold the weapon like a cannon/rocket launcher
            return Vector2.Zero;
        }
    }
}
