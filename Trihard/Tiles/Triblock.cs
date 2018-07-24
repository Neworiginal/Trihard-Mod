using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Trihard.Tiles
{
    public class Triblock : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tridirt");
            Tooltip.SetDefault("I shitted and farted");
        }
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("Triplacable"); //put your CustomBlock Tile name
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);   //you need 10 Wood
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
