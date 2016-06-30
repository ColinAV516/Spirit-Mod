using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Thrown
{
	public class TungstenShuriken : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Shuriken);
            item.name = "Tungsten Shuriken";
            item.width = 30;
            item.height = 30;           
            item.shoot = mod.ProjectileType("TungstenShurikenProjectile");
            item.useAnimation = 16;
            item.useTime = 16;
            item.shootSpeed = 9f;
            item.damage = 19;
            item.knockBack = 0f;
			item.value = Terraria.Item.buyPrice(0, 0, 0, 45);
            item.crit = 5;
            item.rare = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TungstenBar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}