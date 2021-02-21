using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace HandHmod.tiles.HeavenFlame
{
    public class HeavenFlameOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            drop = ItemType<Items.HeavenFlame.HeavenFlameOre>();

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(Microsoft.Xna.Framework.Color.LightCyan);

            minPick = 200;
        }
    }
}
