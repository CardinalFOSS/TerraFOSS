using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Items.Accessories
{
    public class SGOFlower : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Support your local SGO with a small donation of $5!\n+15 Minions <3");
            DisplayName.SetDefault("SGO's Flowers");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Blue; 
            item.value = 2;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 15;
        }
    }
}