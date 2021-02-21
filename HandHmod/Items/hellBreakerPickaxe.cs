﻿using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace HandHmod.Items
{
    public class hellBreakerPickaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(platinum: 99);

            item.autoReuse = true;
            item.useTime = 3;
            item.useAnimation = 20;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 100;
            item.knockBack = 1.75f;

            item.pick = 300;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<hellfirefrag.hellfirebar>(), 99);
            recipe.AddRecipeGroup("Wood", 3);
            recipe.AddRecipeGroup("IronBar", 12);
            recipe.AddIngredient(ItemID.LunarBar, 12);
            recipe.AddIngredient(ItemID.ShroomiteBar, 12);
            recipe.AddIngredient(ItemID.VortexPickaxe, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
