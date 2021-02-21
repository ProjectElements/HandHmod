﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Terraria.Localization;

namespace HandHmod.tiles
{
    public class hellfire_bar :ModTile
    {

        public override void SetDefaults()
        {
            Main.tileShine[Type] = 1100;
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);

            AddMapEntry(Color.DarkRed, Language.GetText("MapObject.hellfirebar"));
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];
            int style = t.frameX / 18;
            int itemType = ModContent.ItemType<Items.hellfirefrag.hellfirebar>();
            switch (style)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }

            Item.NewItem(i * 16, j * 16, 16, 16, itemType);
            return base.Drop(i, j);
        }
    }
}
