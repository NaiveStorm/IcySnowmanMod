using Terraria.ID;
using Terraria.ModLoader;

namespace IcysnowmanMod.Items.weapons.swords
{
	public class SnowionSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("sez"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is sword contains the soul of an old snowman\n this sword shoots a snowball at your mouse location.");
		}

		public override void SetDefaults() 
		{
			item.damage = 29;
			item.melee = true;
			item.width = 16;
			item.height = 16;
			item.useTime = 20;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("SnowSnowBall");
            item.shootSpeed = 7f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Snowball, 100);
			recipe.AddIngredient(ItemID.IceTorch, 50);
			recipe.AddIngredient(mod, "SnowionBar", 14);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}