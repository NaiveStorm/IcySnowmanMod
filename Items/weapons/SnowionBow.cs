using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcysnowmanMod.Items.weapons
{
	public class SnowionBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
 
			Tooltip.SetDefault("this bow shoots arrow.");
		}


        public override void SetDefaults()
        {
            item.Size = new Vector2(25, 25);
            item.value = Item.sellPrice(gold: 1, silver: 75);

			item.autoReuse = false;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;
            item.rare = ItemRarityID.Blue;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 25;
            item.knockBack = 2.5f;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1;
            item.shootSpeed = 7.8f;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("ColdArrow"), damage, knockBack, player.whoAmI, 0f, 0f);
            return false;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddIngredient(mod, "SnowionBar", 9);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}