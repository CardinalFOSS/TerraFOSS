using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Projectiles
{
    public class ReadingProject : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("readings");
        }
        public override void SetDefaults()
        {
            projectile.arrow = true;
            projectile.width = 24;
            projectile.height = 24;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = 4;
            aiType = ProjectileID.Bone;
            projectile.timeLeft = 100;
        }
        public override void PostAI()
        {
            projectile.tileCollide = true;
        }
    }
}