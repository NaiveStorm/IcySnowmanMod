using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcysnowmanMod.Items.tools.pickaxes
{
	public class LyxiumPickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{

			Tooltip.SetDefault("amongus");
		}

		public override void SetDefaults() 
		{
            item.Size = new Vector2(28, 28);
            item.value = Item.sellPrice(gold: 1, silver: 12);
			item.autoReuse = true;
            item.useTime = 6;
            item.useAnimation = 17;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
			item.rare = ItemRarityID.Blue;
            item.melee = true;
            item.damage = 22;
            item.knockBack = 1.5f;

            item.pick = 240;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "LyxiumBar", 18);
            recipe.AddIngredient(ItemID.IceBlock, 60);
            recipe.AddIngredient(ItemID.Gel, 80);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}