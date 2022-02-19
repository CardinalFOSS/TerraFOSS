using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraFOSS.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class MaidDress : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10;
            item.rare = 2;
            item.defense = 9999;
        }

        public override void UpdateEquip(Player player)
        {
            
        }
        public override void AddRecipes() //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}