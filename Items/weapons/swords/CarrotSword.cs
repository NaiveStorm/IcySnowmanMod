using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace IcysnowmanMod.Items.weapons.swords
{
	public class CarrotSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("carrot sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 126;
			item.melee = true;
			item.Size = new Vector2(32, 32);
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 53000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.shoot = mod.ProjectileType("CarrotProj");
			item.shootSpeed = 2.9f;
		}
	}
}