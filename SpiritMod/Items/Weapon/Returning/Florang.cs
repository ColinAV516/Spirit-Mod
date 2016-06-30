using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Returning
{
	public class Florang : ModItem
	{
		public override void SetDefaults()
		{
            item.name = "Florarang";
            item.damage = 14;            
            item.melee = true;
            item.width = 40;
            item.height = 40;
			item.toolTip = "Sharp as a Razorleaf.";
			item.useTime = 30;
			item.useAnimation = 25;
            item.noUseGraphic = true;
            item.useStyle = 1;
			item.knockBack = 3;
			item.value = 8;
			item.rare = 2;
			item.shootSpeed = 6f;
			item.shoot = mod.ProjectileType ("FloraP");
			item.useSound = 1;
			item.autoReuse = true;
		}
        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
        }
        public override void AddRecipes()
        {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "FloranBar", 10);
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
		}
    }
}