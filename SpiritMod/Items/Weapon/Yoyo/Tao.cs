using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Yoyo
{
	public class Tao : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodYoyo);
            item.name = "Equality";
            item.damage = 45;
            item.value = 10;
            item.rare = 4;
            item.knockBack = 2;
            item.channel = true;
            item.useStyle = 5;
            item.useAnimation = 25;
            item.useTime = 23;
            item.shoot = mod.ProjectileType("TaoP");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DarkShard, 1);
            recipe.AddIngredient(ItemID.LightShard, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}