using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace IcysnowmanMod.Items.weapons.Throw
{
    public class TwigStar : ModItem
    {
        
    
    
        public override void SetDefaults()
        {
            item.damage = 80;           
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.consumable = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 8;
            item.rare = 6;
            item.maxStack = 999;
            item.value = 35000;
            item.shootSpeed = 9f;
            item.shoot = mod.ProjectileType ("TwigStarProj");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            
        }
    }
}