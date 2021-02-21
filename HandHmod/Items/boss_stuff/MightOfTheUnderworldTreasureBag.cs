﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HandHmod.Items.boss_stuff
{
    public class MightOfTheUnderworldTreasureBag : ModItem
    {
        public override int BossBagNPC => mod.NPCType("MightOfTheUnderworld");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 32;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = 9;
            item.expert = true;
        }

        public override void OpenBossBag(Player player)
        {
            player.QuickSpawnItem(ItemID.GoldCoin, 99);
            player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 10));
            player.QuickSpawnItem(ItemID.GreaterManaPotion, Main.rand.Next(3, 7));
            player.QuickSpawnItem(mod.ItemType("hellfirebar"),Main.rand.Next(333, 777));
            player.QuickSpawnItem(mod.ItemType("HeavenFlameBar"), Main.rand.Next(333, 777));
            if (Main.rand.Next(7) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("CursedSoulsOfTheDamned"));
            }
            if (Main.rand.Next(100) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("MightOfTheUnderworldTreasureBag"));
            }
        }
    }
}
