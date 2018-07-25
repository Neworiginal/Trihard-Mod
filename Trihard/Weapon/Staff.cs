using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Trihard.Weapon
{
    public class Staff : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tri-Staff");
            Tooltip.SetDefault("Blasts a beam so bright it reveals the blacks at night!!");
        }
        public override void SetDefaults()
        {
            item.damage = 1000;
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 3;
            item.useAnimation = 30;
            item.useStyle = 5;        
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = 10;
            item.mana = 12;             
            item.UseSound = SoundID.Item21;            
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("StaffProjectile");  
            item.shootSpeed = 10f;    
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);              
            recipe.AddIngredient(null, "Watermelon", 50);
            recipe.AddIngredient(null, "Afro", 5);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Stardust"), 200);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("DepthCells"), 100);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Phantoplasm"), 200);
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("MeldBlob"), 100); //nigger
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Genisis"));
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("NuclearFury"));
            recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("ElementalRay"));
            recipe.AddIngredient(ItemID.FragmentNebula, 200);
            recipe.AddIngredient(ItemID.ManaFlower);
            recipe.AddIngredient(ItemID.LunarBar, 200);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
        

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 6; 
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f; 
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .4f; // This defines the projectile roatation and speed. .4f == projectile speed
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

    }
}    

