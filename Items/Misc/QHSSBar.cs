using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Items.Misc
{
    public class QHSSBar : ModItem
    {
        public override void SetDefaults()
        {
            item.value = 300;
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 10;
            item.maxStack = 999;
            item.width = 30;
            item.height = 24;
            item.rare = 2;
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The physical manifestation of QHSSers...");
        }
    }
}