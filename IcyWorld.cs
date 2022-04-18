using System;
using Microsoft.Xna.Framework;
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

namespace IcysnowmanMod
{
    public class IcyWorld : ModWorld
    {
        public static int biomeTiles = 0;
        public static bool downedTutorialBoss = false;
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(x => x.Name.Equals("Shinies"));
            if(shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("Icysnowman Ore Generation", OreGeneration));
            }
        }

        public override void TileCountsAvailable(int[] tileCounts)
        {
            biomeTiles = tileCounts[mod.TileType("LyxiumTile")];
        }

        public override void ResetNearbyTileEffects()
        {
            biomeTiles = 0;
        }
        

        private void OreGeneration(GenerationProgress progress)
        {
            progress.Message = "Generating Snowy Ores";

            for(int i = 0; i < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-04); i++)

            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if(tile.active() && (tile.type == TileID.SnowBlock || tile.type == TileID.IceBlock))
                {
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(4, 9), WorldGen.genRand.Next(4, 9), TileType<tiles.SnowionTile>());
                }


            }

            for(int i = 0; i < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-04); i++)

            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 5), WorldGen.genRand.Next(3, 7), TileType<tiles.LyxiumTile>());
                
            }

            
        }
    }
}
    