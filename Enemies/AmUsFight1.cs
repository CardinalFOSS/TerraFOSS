using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerraFOSS.Items.Misc;

namespace TerraFOSS.Enemies
{
    public class AmUsFight1 : ModNPC
    {
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.05f;
        }
        public override void SetStaticDefaults() {
			DisplayName.SetDefault("Imposter"); // name it shows in game
		}
        public override void SetDefaults()
        {
            npc.width = 50;
            npc.height = 60;
            npc.damage = 45; // dmg it does
            npc.defense = 15; // defense stat
			npc.lifeMax = 500; // health it spawns with
            npc.value = 150f; // coins it drops on death
            npc.aiStyle = 25; // fighter ai
            npc.knockBackResist = 0.4f; // anti kb (hacker omg)
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(9) == 0)
                Item.NewItem(npc.getRect(), ModContent.ItemType<AmongiteBar>());
        }
    }
}