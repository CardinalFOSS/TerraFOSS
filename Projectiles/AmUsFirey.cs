using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Projectiles
{
    public class AmUsFirey : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("hot cheeto infused");
        }
        public override void SetDefaults()
        {
            projectile.arrow = true;
            projectile.width = 9;
            projectile.height = 9;
            projectile.aiStyle = 23;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 6;
            projectile.timeLeft = 160;
        }
        public override void PostAI()
        {
            projectile.tileCollide = true;
        }
    }
}