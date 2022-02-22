using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Projectiles // TerraFOSS is the mod name
                                // Projectiles is the folder that this file is in
{
	public class BucketProject : ModProjectile // bucketproject is subclass which has properties
	{                                    // modprojectile is class that amongus belongs to
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("thrown bucket hat");
		}

		public override void SetDefaults() // place stats here
		{
			projectile.arrow = true;
			projectile.width = 22; // width of projectile that shows up (pixels?)
			projectile.height = 22; // height (pixels?)
			projectile.aiStyle = 3; // https://docs.google.com/spreadsheets/d/1aYgpXehVahT669zxg4B3C2nfxoF8P9mK_clvjgwCTSU/edit#gid=1690991103
            projectile.CloneDefaults(ProjectileID.EnchantedBoomerang);
            // aistyle is how the projectile will interact like (arrows have gravity etc.)
            // clone defaults make it inherit almost every property of enchant boomerang
            projectile.friendly = true; // will not hit friendly npc
			projectile.ranged = true; // this is a ranged asset
			aiType = ProjectileID.EnchantedBoomerang;
            // it will take up the properties of "enchanted boomerang" projectile
			projectile.maxPenetrate = 10; // max enemies projectile can pass through
			projectile.penetrate = 10; // can hit through 10 enemies
			projectile.timeLeft = 100;
			// this projectile will expire in 100 ticks
		}

		// Additional hooks/methods here.
		public override void PostAI()
		{
			projectile.tileCollide = true; // disappears after hitting tiles
		}
	}
}