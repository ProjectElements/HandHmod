using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace HandHmod.Items.armors
{
    [AutoloadEquip(EquipType.Body)]
    public class evil_incarnate_chestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The essence of hell is forged into this armor.");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(platinum: 999);
            item.rare = ItemRarityID.Blue;
            item.defense = 500;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 30);
            recipe.AddIngredient(ItemType<hellfirefrag.hellfirebar>(), 99);
            recipe.AddIngredient(ItemType<HeavenFlame.HeavenFlameBar>(), 99);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
