using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HandHmod.tiles.hellfirefragment
{
    public class hellfirefragments : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMergeDirt[Type] = false;

            drop = ModContent.ItemType<Items.hellfirefrag.hellfirefragments>();

            AddMapEntry(Microsoft.Xna.Framework.Color.DarkRed);

            minPick = 225;
        }
    }
}
