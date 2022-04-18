using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace IcysnowmanMod.Items.bars
{
	public class LyxiumBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("sez"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("snowion bar");
		}

		public override void SetDefaults()
        {
            item.Size = new Vector2(20, 20);
            item.rare = ItemRarityID.Pink;
            item.value = Item.sellPrice(silver: 80, copper: 30);
            item.maxStack = 999;
        }
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "lyxium", 6);
			recipe.AddTile(TileID.Furnaces);
		}		
	}
}