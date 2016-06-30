using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Yoyo
{
	public class Mystic : ModItem
    {

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodYoyo);
            item.name = "Mystic";                      
            item.damage = 25;                            
            item.value = 100;
            item.rare = 4;
            item.knockBack = 2;
            item.channel = true;
            item.useStyle = 5;
            item.useAnimation = 25;
            item.useTime = 27;
            item.shoot = mod.ProjectileType("MysticProjectile"); 
			item.magic = true;
			item.mana = 4;   
			item.toolTip = "A one-of-a-kind yo-yo that uses magic!"; 
			item.melee = false;     
        }
		    }
}