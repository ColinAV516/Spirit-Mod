using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Magic
{
	public class BismiteWrath : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Bismite Wrath";
			item.damage = 12;
			item.magic = true;
			item.mana = 5;
			item.width = 28;
			item.height = 28;
			item.useTime = 19;
			item.useAnimation = 32;
			item.useStyle = 5;
			Item.staff[item.type] = true; 
			item.noMelee = true; 
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 6;
			item.useSound = 20;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("BismiteShot");
			item.shootSpeed = 8f;
        }

public static Vector2[] randomSpread(float speedX, float speedY, int angle, int num)
  {
  var posArray = new Vector2[num];
  float spread = (float)(angle * 0.0174532925);
  float baseSpeed = (float)System.Math.Sqrt(speedX * speedX + speedY * speedY);
  double baseAngle = System.Math.Atan2(speedX, speedY);
  double randomAngle;
  for (int i = 0; i < num; ++i)
  {
  randomAngle = baseAngle + (Main.rand.NextFloat() - 0.5f) * spread;
  posArray[i] = new Vector2(baseSpeed * (float)System.Math.Sin(randomAngle), baseSpeed * (float)System.Math.Cos(randomAngle));
  }
  return (Vector2[])posArray;
  }

  public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
  {
  Vector2[] speeds = randomSpread(speedX, speedY, 8, 3);
  for (int i = 0; i < 5; ++i)
  {
  Projectile.NewProjectile(position.X, position.Y, speeds[i].X, speeds[i].Y, type, damage, knockBack, player.whoAmI);
  }
  return false;
  }
   public override void AddRecipes()
        {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "BismiteCrystal", 8);
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
		}
}}