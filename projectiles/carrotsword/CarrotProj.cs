using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcysnowmanMod.projectiles.carrotsword
{
    public class CarrotProj: ModProjectile
    {
        public override void SetStaticDefaults() {
			DisplayName.SetDefault("a");
        }

        public override void SetDefaults()
        {
            projectile.width = 12;     
            projectile.height = 12;
            projectile.friendly = true;    
            projectile.melee = true;        
            projectile.aiStyle = 1;
            projectile.tileCollide = true; 
            projectile.penetrate = 1;    
            projectile.timeLeft = 200; 
            projectile.light = 2.75f;  
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;


        }
        public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("CarrotProj2"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
                Main.PlaySound(SoundID.Item14);
				Main.projectile[a].tileCollide = true;

			}
			return true;
        }
    }
}