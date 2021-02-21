using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace HandHmod
{
    public class HanHmodWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(x => x.Name.Equals("Shinies"));
            if (shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("HandHmod hell ores Generation", OreGeneration));
                tasks.Insert(shiniesIndex + 1, new PassLegacy("HandHmod heaven ores Generation", OreGeneration));
            }
        }

        private void OreGeneration(GenerationProgress progress)
        {
            progress.Message = "Generating HandHmod Ores";

            for (int i = 0; i < (int)((Main.maxTilesX * Main.maxTilesY) * 7E-04); i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if (tile.active() && (tile.type == TileID.Granite || tile.type == TileID.Marble || tile.type == TileID.Ash))
                {
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(10, 20), WorldGen.genRand.Next(5, 10), TileType<tiles.hellfirefragment.hellfirefragments>());
                }
            }
            int islandsZone = (int)(Main.maxTilesY * 0.18f);
            // Max to Spawn
            int numSpawned = 0;
            int maxToSpawn = 500000;
            // For Loop
            for (int i = 0; i < Main.maxTilesX; i++)
            {
                // Get X and Y coords
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next(0, islandsZone);
                // Get the Tile
                Tile tile = Main.tile[x, y];
                // Check if Active (if there is an error try tile.active())
                if (tile.active())
                {
                    // Create the Tiles
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(10, 20), WorldGen.genRand.Next(5, 10), ModContent.TileType<tiles.HeavenFlame.HeavenFlameOre>());
                    // Increase Number Spawned
                    numSpawned++;
                    // Break Look is Number Spawned == Max Spawned
                    if (numSpawned == maxToSpawn)
                    {
                        break;
                    }
                }
            }
        }
    }
}
