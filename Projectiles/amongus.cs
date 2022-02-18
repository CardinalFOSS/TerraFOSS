using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Projectiles // TerraFOSS is the mod name
                                // Projectiles is the folder that this file is in
{
	public class amongus : ModProjectile // amongus is subclass which has properties
	{                                    // modprojectile is class that amongus belongs to
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("amongus projectile");
		}

		public override void SetDefaults() // place stats here
		{
			projectile.arrow = true;
			projectile.width = 16; // width of projectile that shows up (pixels?)
			projectile.height = 16; // height (pixels?)
			projectile.aiStyle = 5; // https://docs.google.com/spreadsheets/d/1aYgpXehVahT669zxg4B3C2nfxoF8P9mK_clvjgwCTSU/edit#gid=1690991103
            // aistyle is how the projectile will interact like (arrows have gravity etc.)
            projectile.friendly = true; // will not hit friendly npc
			projectile.ranged = true; // this is a ranged asset
			aiType = ProjectileID.FallingStar;
            // it will take up the properties of "falling star" projectile
		}

		// Additional hooks/methods here.
	}
}