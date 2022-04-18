using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IcysnowmanMod.projectiles.carrotsword
{
    public class CarrotProj2 : ModProjectile
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
            projectile.light = 1.75f;  
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;


        }

        public override bool OnTileCollide(Vector2 oldVelocity) {
            Main.PlaySound(SoundID.Item10);
            return true;
        }
    }
}