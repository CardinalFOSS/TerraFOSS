using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Items // TerraFOSS is the mod name
                          // Items is the folder that this file is in
{
	public class TestSword : ModItem // testsword is subclass which has properties
									 // moditem is class that amongus belongs to
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults() // place stats here
		{
			item.damage = 150; // dmg
			item.melee = true; // this is a melee weapon (stat?)
			item.width = 40; // width of the sword on screen (pixels?)
			item.height = 40; // height (pixels?)
			item.useTime = 20; // how long it takes to use weapon again
			item.useAnimation = 20; // how long it takes for use animation to end
			item.useStyle = 1;
			item.knockBack = 6; // kb
			item.value = 10000; 
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; // autoswing (hold to attack)
			item.shoot = mod.ProjectileType("amongus"); // check projectiles
            item.shootSpeed = 5f; // speed of projectile
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}