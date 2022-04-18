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

namespace IcysnowmanMod.Items.place
{
    public class lyxium : ModItem
    {
        public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("While alien were dominating this world, due to extreme toxicity \n in the air and water this big big rock exploded,\n leaving pieces of it all over the world :)");
		}
        public override void SetDefaults()
        {
            item.Size = new Vector2(12);

            item.value = Item.sellPrice(copper: 69);
            item.autoReuse = true;
            item.useTurn = true;
            item.useTime = 10;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.consumable = true;
            item.maxStack = 999;
            item.rare = 2;

            item.createTile = mod.TileType("LyxiumTile");

        }
    }
}