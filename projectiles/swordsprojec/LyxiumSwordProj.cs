using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace IcysnowmanMod.projectiles.swordsprojec
{
    public class LyxiumSwordProj : ModProjectile
    {
        public override void SetStaticDefaults() {
			DisplayName.SetDefault("creates a projectile that will remain still\n until the time limit is reached");
        }
        
        public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
            projectile.timeLeft = 240;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.Starfury;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, ProjectileID.Starfury, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 5;
				Main.projectile[a].tileCollide = true;
			}
			return true;
        }
    }
}