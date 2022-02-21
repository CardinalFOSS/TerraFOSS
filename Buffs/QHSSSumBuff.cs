using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerraFOSS.Projectiles;

namespace TerraFOSS.Buffs
{
    public class QHSSSumBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Essence of QHSS");
            Description.SetDefault("Strike down your foes with QHSS!");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[ModContent.ProjectileType<QHSSProject>()] > 0) {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
    }
}