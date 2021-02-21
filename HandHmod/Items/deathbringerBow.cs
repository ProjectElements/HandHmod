using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;
using HandHmod.Items.hellfirefrag;

namespace HandHmod.Items
{
    public class deathbringerBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("deathbringerBow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A bow created to hunt down cursed souls.");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(12, 24);
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(platinum: 99);

            item.useTime = 1;
            item.useAnimation = 1;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 674;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = 100;
            item.shootSpeed = 1000f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarOre, 99);
            recipe.AddIngredient(ItemID.HellstoneBar, 99);
            recipe.AddIngredient(ItemID.Phantasm, 1);
            recipe.AddIngredient(ItemID.VortexBeater, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}