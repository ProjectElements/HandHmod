using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace HandHmod.Items.hellfirefrag
{
    public class hellfirefragments : ModItem
    {
        public override void SetDefaults()
        {
            //Hitbox Size
            item.width = 12;
            item.height = 12;
            // Stack and Value
            item.maxStack = 999;
            item.value = Item.buyPrice(gold: 90);
            item.rare = ItemRarityID.Cyan;
            item.consumable = true;
            //usage
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;
            // create tile
            item.createTile = ModContent.TileType<tiles.hellfirefragment.hellfirefragments>();
        }
    }
}
