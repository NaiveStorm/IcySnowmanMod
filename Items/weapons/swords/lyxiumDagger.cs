using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace IcysnowmanMod.Items.weapons.swords
{
	public class lyxiumDagger : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Lixyum dagger");
		}

		public override void SetDefaults() 
		{
			item.damage = 150;
			item.melee = true;
			item.Size = new Vector2(16, 16);
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("LyxiumSwordProj");
			item.shootSpeed = 0.3f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 25);
			recipe.AddIngredient(mod, "LyxiumBar", 28);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}