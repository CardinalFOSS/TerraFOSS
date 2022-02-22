using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerraFOSS.Items.Misc;

namespace TerraFOSS.Enemies
{
    public class PotMimic : ModNPC
    {
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDay.Chance * 0.005f;
        }
        public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pot Mimic"); // name it shows in game
		}
        public override void SetDefaults()
        {
            npc.width = 24;
            npc.height = 26;
            npc.damage = 60; // dmg it does
            npc.defense = 40; // defense stat
			npc.lifeMax = 1200; // health it spawns with
            npc.value = 1500f; // coins it drops on death
            npc.aiStyle = 25; // mimic ai
            npc.knockBackResist = 10f;
        }
    }
}