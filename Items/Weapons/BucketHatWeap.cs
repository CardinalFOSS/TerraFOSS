using Terraria.ID;
using Terraria.ModLoader;
using TerraFOSS.Items.Misc;

namespace TerraFOSS.Items.Weapons // TerraFOSS is the mod name
                          // Items is the folder that this file is in
{
	public class BucketHatWeap : ModItem // buckethatweap is subclass which has properties
									 // moditem is class that amongus belongs to
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("This isn't the right one!");
            DisplayName.SetDefault("Bucket Hat");
		}

		public override void SetDefaults() // place stats here
		{
			item.damage = 10; // dmg
			item.melee = true; // this is a melee weapon (stat?)
			item.width = 18; // width of the sword on screen (pixels?)
			item.height = 32; // height (pixels?)
			item.useTime = 5; // how long it takes to use weapon again
			item.useAnimation = 5; // how long it takes for use animation to end
			item.useStyle = 1;
			item.knockBack = 10; // kb
			item.value = 6000; // how much you can sell this item for
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; // autoswing (hold to attack)
			item.shoot = mod.ProjectileType("BucketProject"); // check projectiles
            item.shootSpeed = 10f; // speed of projectile
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<QHSSBar>(), 8); // 10 qhssbars
			recipe.AddTile(TileID.WorkBenches); // make at a workbench
			recipe.SetResult(this); // makes this item
			recipe.AddRecipe();
		}
	}
}