using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace TerraFOSS.Items.Armor
{
    [AutoloadEquip(EquipType.Body)] // equip it on the body
    public class MaidDress : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10; // how much you can sell it for
            item.rare = 2;
            item.defense = 9999; // defense stat
        }

        public override void UpdateEquip(Player player)
        {
            // place armor set buffs here
        }
        public override void AddRecipes() //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1); // 1 dirt = this
            recipe.AddTile(TileID.WorkBenches); // make at workbench
            recipe.SetResult(this); // makes this item
            recipe.AddRecipe();
        }
    }
}