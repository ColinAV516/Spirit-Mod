using System;
using Terraria;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Yoyo
{
	public class Fungus : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Fungus";
			item.width = 30;
			item.height = 26;
			item.toolTip = "";
			item.value = Terraria.Item.sellPrice(0, 1, 0, 0);
			item.rare = 3;
			item.crit += 4;
			item.damage = 54;
			item.knockBack = 3f;
			item.useStyle = 5;
			item.useTime = 25;
			item.useAnimation = 25;
			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType("Saprophyte");
			item.useSound = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(2, 1);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}
	}
}
