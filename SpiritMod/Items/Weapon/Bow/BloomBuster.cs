using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Bow
{
    public class BloomBuster : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Bloom Buster";
            item.damage = 24;
            item.noMelee = true;
            item.ranged = true;
            item.width = 16;
            item.height = 32;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = 5;
            item.shoot = 4;
            item.useAmmo = 1;
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 1;
            item.useSound = 1;
            item.autoReuse = false;
            item.shootSpeed = 6.7f;            
        }               
    }
}