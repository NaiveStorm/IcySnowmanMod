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
    public class SnowionOre : ModItem
    {
        public override void SetStaticDefaults() 
		{
			
			Tooltip.SetDefault("this re was generated cuz alien... yeh");
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

            item.createTile = mod.TileType("SnowionTile");

        }
    }
}