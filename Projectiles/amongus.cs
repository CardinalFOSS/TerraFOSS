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
			drawOffsetX = -23; // offset sprite to match hitbox
			drawOriginOffsetY = -25; // offset sprite to match hitbox
			projectile.maxPenetrate = 3; // max enemies projectile can pass through
			projectile.penetrate = 3; // can hit through 3 enemies
			projectile.timeLeft = 300;
			// this projectile will expire in 300 ticks
			// (locally) to convert to seconds, do 300 divided by your frame rate
			// i (ryan) am running at 45 fps so it will take about 7 seconds for it to expire
			// on servers, it will default at 60 ticks per second so it will expire at 5 seconds but will look laggy on 45 fps screens
		}

		// Additional hooks/methods here.
		public override void PostAI()
		{
			projectile.tileCollide = false; // will not die when hitting tiles
		}
	}
}