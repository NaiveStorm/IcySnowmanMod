using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace IcysnowmanMod.Items.weapons
{
    public class Hatarang : ModItem
    {
        
    
    
        public override void SetDefaults()
        {
            item.damage = 80;           
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 25;
            item.useAnimation = 25;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 8;
            item.rare = 6;
            item.value = 35000;
            item.shootSpeed = 9f;
            item.shoot = mod.ProjectileType ("BoomerangProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            
        }

        
        public override bool CanUseItem(Player player)       //no
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                
                {
                    return true;
                }
            }
            return true;
        }
    }
}