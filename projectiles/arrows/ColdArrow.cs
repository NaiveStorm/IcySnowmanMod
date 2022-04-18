using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcysnowmanMod.projectiles.arrows
{
    public class ColdArrow: ModProjectile
    {
        public override void SetStaticDefaults() {
			DisplayName.SetDefault("cold arrow\n bottom text");
        }

        public override void SetDefaults()
        {

            projectile.damage = 9;
            projectile.width = 12;     
            projectile.height = 12;
            projectile.friendly = true;    
            projectile.ranged = true;        
            projectile.aiStyle = 1;
            projectile.tileCollide = true; 
            projectile.penetrate = 3;    
            projectile.timeLeft = 600; 
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