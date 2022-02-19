using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Items.Misc
{
    public class AmongiteBar : ModItem
    {
        public override void SetDefaults()
        {
            item.value = 200;
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 10;
            item.maxStack = 999;
            item.width = 20;
            item.height = 20;
            item.rare = 2;
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This bar is looking kinda sussy!");
        }
    }
}