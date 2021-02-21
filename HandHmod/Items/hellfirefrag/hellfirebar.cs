﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HandHmod.Items.hellfirefrag
{
    public class hellfirebar : ModItem
    {
        public override void SetDefaults()
        {
            //Hitbox Size
            item.width = 12;
            item.height = 12;
            // Stack and Value
            item.maxStack = 999;
            item.value = Item.buyPrice(gold: 99);
            item.rare = ItemRarityID.Cyan;
            item.consumable = true;
            //usage
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;
            // create tile
            item.createTile = ModContent.TileType<tiles.hellfire_bar>();
            item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<hellfirefragments>(), 12);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
