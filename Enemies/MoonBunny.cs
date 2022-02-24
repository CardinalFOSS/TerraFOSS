using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Enemies
{
    public class MoonBunny : ModNPC
    {
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {   //Seed is Kelvin and kelvin respectively (case sensitive)
            // use Main.NewText(WorldGen._lastSeed, Color.Lime); to get seed
            // place it in an equip hook or something

            // NOTE, YOU CANNOT MANUALLY SET SEEDS WHEN CREATING A WORLD UNLESS YOU HAVE EXPERIMENTAL FEATURES ON
            if ((WorldGen._lastSeed == 2023951915) || (WorldGen._lastSeed == 957089475))
            {
                return SpawnCondition.OverworldDay.Chance * 0.1f;
            }
            else
            {
                return SpawnCondition.OverworldDay.Chance * 0.0001f;
            }
        }
        public override void SetStaticDefaults() {
			DisplayName.SetDefault("Moon Bunny"); // name it shows in game
		}
        public override void SetDefaults()
        {
            npc.width = 28;
            npc.height = 26;
            npc.damage = 1; // dmg it does
            npc.defense = 1; // defense stat
			npc.lifeMax = 5; // health it spawns with
            npc.value = 15000f; // coins it drops on death
            npc.aiStyle = 25; // fighter ai
            npc.knockBackResist = 0f; // anti kb (hacker omg)
        }
        public override void NPCLoot()
        {   // npc position.X/Y return the position of the mob
            // npc loot is the hook used to check what happens when the mob dies
            NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.MoonLordCore);
        }
        public override void PostAI()
		{   // post ai checks to see what it does once its spawned
            // this code below makes the sprite flip depending on which way its going
			npc.spriteDirection = npc.direction;
		}
    }
}
