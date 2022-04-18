using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcysnowmanMod.projectiles.swordsprojec
{
    public class SnowSnowBall: ModProjectile
    {
        public override void SetStaticDefaults() {
			DisplayName.SetDefault("creates a projectile that will remain still\n until the time limit is reached");
        }

        public override void SetDefaults()
        {
            projectile.width = 15;     
            projectile.height = 15;
            projectile.friendly = true;    
            projectile.melee = true;        
            projectile.aiStyle = 1;
            projectile.tileCollide = true; 
            projectile.penetrate = 30;    
            projectile.timeLeft = 200; 
            projectile.light = 0.75f;  
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true; 
        }
    
        public override void AI()         
            {                                                         
                projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            }
    }
}