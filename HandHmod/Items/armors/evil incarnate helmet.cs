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
using HandHmod.Items.hellfirefrag;

namespace HandHmod.Items.armors
{
    [AutoloadEquip(EquipType.Head)]
    public class evil_incarnate_helmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The essence of hell is forged into this armor.");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(platinum: 99);
            item.rare = ItemRarityID.Blue;
            item.defense = 400;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 20);
            recipe.AddIngredient(ItemType<hellfirebar>(), 95);
            recipe.AddIngredient(ItemType<HeavenFlame.HeavenFlameBar>(), 90);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<evil_incarnate_chestplate> () && legs.type == ItemType<evil_incarnate_greaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage += 0.5f;
            player.rangedDamage += 0.5f;
            player.moveSpeed += 50.5f;
        }
    }
}
