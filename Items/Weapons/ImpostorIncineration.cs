using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerraFOSS.Items.Misc;

namespace TerraFOSS.Items.Weapons
{
    public class ImpostorIncineration : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 35;
            item.ranged = true;
            item.width = 45;
            item.height = 17;
            item.useTime = 10;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AmUsFirey");
            item.useAmmo = AmmoID.Gel;
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<AmongiteBar>(), 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("For setting Impostors on fire!");
        }
    }
}