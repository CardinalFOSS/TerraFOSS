using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerraFOSS.Items.Misc;

namespace TerraFOSS.Items.Weapons
{
    public class StripPoleWeap : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stripper's Pole");
			Tooltip.SetDefault("PROPERTY OF XTTORI");
        }
        public override void SetDefaults()
        {
            item.damage = 69;
            item.knockBack = 5;
			item.width = 45;
			item.height = 54;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 3;
			item.value = 1000;
			item.rare = ItemRarityID.Cyan;
            item.melee = true;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<QHSSBar>(), 18); // 10 dirt to craft
			recipe.AddTile(TileID.WorkBenches); // make at a workbench
			recipe.SetResult(this); // makes this item
			recipe.AddRecipe();
		}
    }
}