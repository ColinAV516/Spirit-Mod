using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Swung
{
    public class BismiteSword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bismite Sword";     
            item.damage = 16;            
            item.melee = true;            
            item.width = 34;              
            item.height = 40;             
            item.toolTip = "On use,Shoots an Bismite Wrath Shard";  
            item.useTime = 21;           
            item.useAnimation = 21;     
            item.useStyle = 1;        
            item.knockBack = 6;      
            item.value = 10000;        
            item.rare = 1;
            item.useSound = 1;       
            item.shoot = mod.ProjectileType("BismiteSwordProjectile");
            item.shootSpeed = 10f;            
            item.crit = 8;                     
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null,"BismiteCrystal", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}